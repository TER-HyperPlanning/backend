using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ISessionRepository : IAsyncRepository<SessionModel>
{
    Task<string?> GetSessionTypeIdByLabelAsync(string label);
    Task<string?> GetSessionStatusIdByLabelAsync(string label);
    Task<bool> CourseExistsAsync(string courseId);
    Task<bool> RoomExistsAsync(string roomId);
    Task<IEnumerable<string>> GetAffectedUserIdsAsync(string sessionId);
    Task<IReadOnlyList<SessionModel>> GetDeletedAsync();
}