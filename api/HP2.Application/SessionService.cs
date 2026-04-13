using HP2.Application.Contracts;
using HP2.Domain.Models;
using Microsoft.Extensions.Logging;

namespace HP2.Application;

public class SessionService : ISessionService
{
    private readonly ISessionRepository _sessionRepository;
    private readonly INotificationService _notificationService;

    private readonly ILogger<SessionService> _logger;

    public SessionService(ISessionRepository sessionRepository, INotificationService notificationService, ILogger<SessionService> logger)
    {
        _sessionRepository = sessionRepository;
        _notificationService = notificationService;
        _logger = logger;
    }

    public async Task<SessionModel> CreateSessionAsync(SessionModel session)
    {
        var createdSession = await _sessionRepository.AddAsync(session);

        // Envoyer une notification aux étudiants et profs concernés
        var userIds = await _sessionRepository.GetAffectedUserIdsAsync(createdSession.Id);
        if (userIds.Any())
        {
            await _notificationService.NotifyUsersAsync(
                userIds.ToList(),
                "Nouvelle séance ajoutée",
                $"Une nouvelle séance de {createdSession.CourseName ?? "Cours"} a été programmée le {createdSession.StartDateTime:dd/MM/yyyy HH:mm}.",
                "SessionCreation",
                createdSession.Id
            );
        }

        return createdSession;
    }

    public Task<SessionModel?> GetSessionByIdAsync(string id)
        => _sessionRepository.GetByIdAsync(id);

    public async Task<IEnumerable<SessionModel>> GetAllSessionsAsync()
        => await _sessionRepository.GetAllAsync();

    public async Task UpdateSessionAsync(SessionModel session)
    {
        // Récupérer l'ancienne version de la séance pour comparer
        var oldSession = await _sessionRepository.GetByIdAsync(session.Id);
        
        await _sessionRepository.UpdateAsync(session);
        
        // Récupérer la nouvelle version pour avoir les labels frais (salle, type, etc.)
        var newSession = await _sessionRepository.GetByIdAsync(session.Id);

        if (oldSession == null || newSession == null) return;

        // Identifier les changements détaillés
        var changes = new List<string>();
        
        bool startChanged = oldSession.StartDateTime != newSession.StartDateTime;
        bool endChanged = oldSession.EndDateTime != newSession.EndDateTime;
        bool dateChanged = oldSession.StartDateTime.Date != newSession.StartDateTime.Date;

        if (startChanged && endChanged)
        {
            string oldFormat = dateChanged ? $"{oldSession.StartDateTime:dd/MM/yyyy HH:mm}-{oldSession.EndDateTime:HH:mm}" : $"{oldSession.StartDateTime:HH:mm}-{oldSession.EndDateTime:HH:mm}";
            string newFormat = dateChanged ? $"{newSession.StartDateTime:dd/MM/yyyy HH:mm}-{newSession.EndDateTime:HH:mm}" : $"{newSession.StartDateTime:HH:mm}-{newSession.EndDateTime:HH:mm}";
            changes.Add($"l'horaire complet (de {oldFormat} à {newFormat})");
        }
        else if (startChanged)
        {
            string oldFormat = dateChanged ? $"{oldSession.StartDateTime:dd/MM/yyyy HH:mm}" : $"{oldSession.StartDateTime:HH:mm}";
            string newFormat = dateChanged ? $"{newSession.StartDateTime:dd/MM/yyyy HH:mm}" : $"{newSession.StartDateTime:HH:mm}";
            changes.Add($"l'heure de début (de {oldFormat} à {newFormat})");
        }
        else if (endChanged)
        {
            string oldFormat = dateChanged ? $"{oldSession.EndDateTime:dd/MM/yyyy HH:mm}" : $"{oldSession.EndDateTime:HH:mm}";
            string newFormat = dateChanged ? $"{newSession.EndDateTime:dd/MM/yyyy HH:mm}" : $"{newSession.EndDateTime:HH:mm}";
            changes.Add($"l'heure de fin (de {oldFormat} à {newFormat})");
        }
        
        if (oldSession.RoomId != newSession.RoomId)
            changes.Add($"la salle (de {oldSession.RoomNumber ?? "Inconnue"} à {newSession.RoomNumber ?? "Inconnue"})");
        
        if (oldSession.Mode != newSession.Mode)
            changes.Add($"le mode (de {TranslateMode(oldSession.Mode)} à {TranslateMode(newSession.Mode)})");
            
        if (oldSession.SessionTypeId != newSession.SessionTypeId)
            changes.Add($"le type de séance (de {oldSession.SessionTypeLabel ?? "Inconnu"} à {newSession.SessionTypeLabel ?? "Inconnu"})");

        if (oldSession.CourseId != newSession.CourseId)
            changes.Add($"le module (de {oldSession.CourseName ?? "Inconnu"} à {newSession.CourseName ?? "Inconnu"})");

        var oldDesc = string.IsNullOrWhiteSpace(oldSession.Description) ? "Aucune" : oldSession.Description;
        var newDesc = string.IsNullOrWhiteSpace(newSession.Description) ? "Aucune" : newSession.Description;
        if (oldDesc != newDesc)
            changes.Add($"la description (de {oldDesc} à {newDesc})");

        if (changes.Count == 0) return;

        string description;
        if (changes.Count == 1)
        {
            // On capitalise la première lettre
            string detailedChange = char.ToUpper(changes[0][0]) + changes[0].Substring(1);
            bool isFeminine = changes[0].Contains("salle");
            description = $"{detailedChange} a été modifié{(isFeminine ? "e" : "")}.";
        }
        else
        {
            description = $"Les détails suivants ont été modifiés : {string.Join(", ", changes.SkipLast(1))} et {changes.Last()}.";
        }

        // Envoyer une notification à tous les utilisateurs concernés
        var userIds = (await _sessionRepository.GetAffectedUserIdsAsync(session.Id)).ToList();
        
        if (userIds.Any())
        {
            await _notificationService.NotifyUsersAsync(
                userIds,
                "Séance mise à jour",
                $"La séance de {session.CourseName ?? "Cours"} prévue le {session.StartDateTime:dd/MM/yyyy HH:mm} : {description}",
                "SessionUpdate",
                session.Id
            );
        }
    }

    public async Task DeleteSessionAsync(string id)
    {
        // On récupère les infos avant la suppression pour la notif
        var session = await _sessionRepository.GetByIdAsync(id);
        var userIds = await _sessionRepository.GetAffectedUserIdsAsync(id);

        await _sessionRepository.DeleteAsync(id);

        if (session != null && userIds.Any())
        {
            await _notificationService.NotifyUsersAsync(
                userIds.ToList(),
                "Séance annulée",
                $"La séance de {session.CourseName ?? "Cours"} prévue le {session.StartDateTime:dd/MM/yyyy HH:mm} a été annulée.",
                "SessionCancellation",
                id
            );
        }
    }

    public Task<string?> GetSessionTypeIdAsync(string label)
        => _sessionRepository.GetSessionTypeIdByLabelAsync(label);

    public Task<string?> GetSessionStatusIdAsync(string label)
        => _sessionRepository.GetSessionStatusIdByLabelAsync(label);

    public Task<bool> CourseExistsAsync(string courseId)
        => _sessionRepository.CourseExistsAsync(courseId);

    public Task<bool> RoomExistsAsync(string roomId)
        => _sessionRepository.RoomExistsAsync(roomId);

    public async Task<IEnumerable<SessionModel>> GetDeletedSessionsAsync()
        => await _sessionRepository.GetDeletedAsync();

    private string TranslateMode(HP2.Domain.Enums.SessionMode mode) => mode switch
    {
        HP2.Domain.Enums.SessionMode.PRESENTIAL => "Présentiel",
        HP2.Domain.Enums.SessionMode.ONLINE => "Distanciel",
        HP2.Domain.Enums.SessionMode.HYBRID => "Hybride",
        _ => mode.ToString()
    };
}