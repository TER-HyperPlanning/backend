using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class SessionService : ISessionService
{
    private readonly ISessionRepository _sessionRepository;

    public SessionService(ISessionRepository sessionRepository)
    {
        _sessionRepository = sessionRepository;
    }

    public Task<SessionModel> CreateSessionAsync(SessionModel session)
        => _sessionRepository.AddAsync(session);

    public Task<SessionModel?> GetSessionByIdAsync(string id)
        => _sessionRepository.GetByIdAsync(id);

    public async Task<IEnumerable<SessionModel>> GetAllSessionsAsync()
        => await _sessionRepository.GetAllAsync();

    public Task UpdateSessionAsync(SessionModel session)
        => _sessionRepository.UpdateAsync(session);

    public Task DeleteSessionAsync(string id)
        => _sessionRepository.DeleteAsync(id);

    public Task<string?> GetSessionTypeIdAsync(string label)
        => _sessionRepository.GetSessionTypeIdByLabelAsync(label);

    public Task<string?> GetSessionStatusIdAsync(string label)
        => _sessionRepository.GetSessionStatusIdByLabelAsync(label);

    public Task<bool> CourseExistsAsync(string courseId)
        => _sessionRepository.CourseExistsAsync(courseId);

    public Task<bool> RoomExistsAsync(string roomId)
        => _sessionRepository.RoomExistsAsync(roomId);
    public async Task<IEnumerable<SessionModel>> GetDeletedSessionsAsync()
        => _sessionRepository.GetDeletedAsync();
}