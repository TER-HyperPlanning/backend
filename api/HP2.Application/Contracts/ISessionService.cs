using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ISessionService
{
    Task<SessionModel> CreateSessionAsync(SessionModel session);
    Task<SessionModel?> GetSessionByIdAsync(string id);
    Task<IEnumerable<SessionModel>> GetAllSessionsAsync();
    Task UpdateSessionAsync(SessionModel session);
    Task DeleteSessionAsync(string id);

}