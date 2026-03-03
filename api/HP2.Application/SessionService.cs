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

    public async Task<SessionModel> CreateSessionAsync(SessionModel session)
    {
        session.CreatedAt = DateTime.UtcNow;
        session.UpdatedAt = DateTime.UtcNow;

        return await _sessionRepository.AddAsync(session);
    }

    public async Task<SessionModel?> GetSessionByIdAsync(string id)
    {
        return await _sessionRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<SessionModel>> GetAllSessionsAsync()
    {
        return await _sessionRepository.GetAllAsync();
    }

    public async Task UpdateSessionAsync(SessionModel session)
    {
        session.UpdatedAt = DateTime.UtcNow;
        await _sessionRepository.UpdateAsync(session);
    }

    public async Task DeleteSessionAsync(string id)
    {
        await _sessionRepository.DeleteAsync(id);
    }
}