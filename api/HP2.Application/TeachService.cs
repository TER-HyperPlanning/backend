using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class TeachService : ITeachService
{
    private readonly ITeachRepository _repository;
    private readonly INotificationService _notificationService;
    private readonly ISessionRepository _sessionRepository;

    public TeachService(ITeachRepository repository, INotificationService notificationService, ISessionRepository sessionRepository)
    {
        _repository = repository;
        _notificationService = notificationService;
        _sessionRepository = sessionRepository;
    }

    public async Task<TeachModel> AddAsync(TeachModel model)
    {
        var result = await _repository.AddAsync(model);
        
        // --- Notification au professeur ---
        var session = await _sessionRepository.GetByIdAsync(model.SessionId);
        
        if (session != null)
        {
            await _notificationService.NotifyUsersAsync(
                new List<string> { model.TeacherId }, // Seulement le professeur concerné
                "Nouvelle séance attribuée",
                $"Vous avez été assigné(e) à une séance de {session.CourseName ?? "Cours"} prévue le {session.StartDateTime:dd/MM/yyyy HH:mm}.",
                "SessionCreation",
                session.Id
            );
        }
        // ---------------------------------
        
        return result;
    }

    public Task<TeachModel> UpdateAsync(string currentSessionId, string currentTeacherId, TeachModel model)
        => _repository.UpdateAsync(currentSessionId, currentTeacherId, model);

    public async Task<bool> DeleteAsync(string sessionId, string teacherId)
    {
        var session = await _sessionRepository.GetByIdAsync(sessionId);
        
        var result = await _repository.DeleteAsync(sessionId, teacherId);

        if (result && session != null)
        {
            await _notificationService.NotifyUsersAsync(
                new List<string> { teacherId },
                "Séance annulée",
                $"La séance de {session.CourseName ?? "Cours"} prévue le {session.StartDateTime:dd/MM/yyyy HH:mm} a été annulée.",
                "SessionCancellation",
                sessionId
            );
        }

        return result;
    }

    public Task<IReadOnlyList<TeachModel>> GetAllAsync() => _repository.GetAllAsync();

    public Task<IReadOnlyList<TeachModel>> GetBySessionIdAsync(string sessionId) => _repository.GetBySessionIdAsync(sessionId);

    public Task<IReadOnlyList<TeachModel>> GetByTeacherIdAsync(string teacherId) => _repository.GetByTeacherIdAsync(teacherId);

    public Task<bool> ExistsAsync(string sessionId, string teacherId) => _repository.ExistsAsync(sessionId, teacherId);

    public Task<bool> SessionExistsAsync(string sessionId) => _repository.SessionExistsAsync(sessionId);

    public Task<bool> TeacherExistsAsync(string teacherId) => _repository.TeacherExistsAsync(teacherId);
}
