using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class SessionService : ISessionService
{
    private readonly ISessionRepository _repo;

    public SessionService(ISessionRepository repo)
    {
        _repo = repo;
    }

    public Task<SessionModel> CreateSessionAsync(SessionModel session) => _repo.AddAsync(session);
    public Task<SessionModel?> GetSessionByIdAsync(string id) => _repo.GetByIdAsync(id);
    public async Task<IEnumerable<SessionModel>> GetAllSessionsAsync() => await _repo.GetAllAsync();
    public Task UpdateSessionAsync(SessionModel session) => _repo.UpdateAsync(session);
    public Task DeleteSessionAsync(string id) => _repo.DeleteAsync(id);
}