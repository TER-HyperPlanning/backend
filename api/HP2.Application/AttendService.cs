using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class AttendService : IAttendService
{
    private readonly IAttendRepository _repository;
    private readonly INotificationService _notificationService;
    private readonly ISessionRepository _sessionRepository;

    public AttendService(IAttendRepository repository, INotificationService notificationService, ISessionRepository sessionRepository)
    {
        _repository = repository;
        _notificationService = notificationService;
        _sessionRepository = sessionRepository;
    }

    public async Task<AttendModel> AddAsync(AttendModel model)
    {
        var result = await _repository.AddAsync(model);
        
        // --- Notification ---
        var session = await _sessionRepository.GetByIdAsync(model.SessionId);
        var userIds = await _sessionRepository.GetAffectedUserIdsAsync(model.SessionId);
        
        if (session != null && userIds.Any())
        {
            await _notificationService.NotifyUsersAsync(
                userIds.ToList(),
                "Nouvelle séance attribuée",
                $"Une séance de {session.CourseName ?? "Cours"} vous a été attribuée le {session.StartDateTime:dd/MM/yyyy HH:mm}.",
                "SessionCreation",
                session.Id
            );
        }
        // --------------------

        return result;
    }

    public Task<AttendModel> UpdateAsync(string currentGroupId, string currentSessionId, AttendModel model)
        => _repository.UpdateAsync(currentGroupId, currentSessionId, model);

    public async Task<bool> DeleteAsync(string groupId, string sessionId)
    {
        var session = await _sessionRepository.GetByIdAsync(sessionId);
        var userIds = await _repository.GetAffectedUserIdsAsync(groupId);
        
        var result = await _repository.DeleteAsync(groupId, sessionId);

        if (result && session != null && userIds.Any())
        {
            await _notificationService.NotifyUsersAsync(
                userIds.ToList(),
                "Séance supprimée",
                $"La séance de {session.CourseName ?? "Cours"} prévue le {session.StartDateTime:dd/MM/yyyy HH:mm} a été supprimée de votre emploi du temps.",
                "SessionCancellation",
                sessionId
            );
        }
        
        return result;
    }

    public Task<IReadOnlyList<AttendModel>> GetAllAsync() => _repository.GetAllAsync();

    public Task<IReadOnlyList<AttendModel>> GetByGroupIdAsync(string groupId) => _repository.GetByGroupIdAsync(groupId);

    public Task<IReadOnlyList<AttendModel>> GetBySessionIdAsync(string sessionId) => _repository.GetBySessionIdAsync(sessionId);

    public Task<bool> ExistsAsync(string groupId, string sessionId) => _repository.ExistsAsync(groupId, sessionId);

    public Task<bool> GroupExistsAsync(string groupId) => _repository.GroupExistsAsync(groupId);

    public Task<bool> SessionExistsAsync(string sessionId) => _repository.SessionExistsAsync(sessionId);
}
