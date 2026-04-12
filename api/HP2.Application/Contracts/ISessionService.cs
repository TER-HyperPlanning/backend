using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ISessionService
{
    Task<SessionModel> CreateSessionAsync(SessionModel session);
    Task<SessionModel?> GetSessionByIdAsync(string id);
    Task<IEnumerable<SessionModel>> GetAllSessionsAsync();
    Task UpdateSessionAsync(SessionModel session);
    Task DeleteSessionAsync(string id);

    Task<string?> GetSessionTypeIdAsync(string label);
    Task<string?> GetSessionStatusIdAsync(string label);
    Task<bool> CourseExistsAsync(string courseId);
    Task<bool> RoomExistsAsync(string roomId);
    Task<IEnumerable<SessionModel>> SearchSessionsAsync(string? groupId, string? type, string? search);
    Task<IEnumerable<SessionModel>> GetDeletedSessionsAsync();
}