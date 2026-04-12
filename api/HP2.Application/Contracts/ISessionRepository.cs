using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ISessionRepository : IAsyncRepository<SessionModel>
{
    Task<IEnumerable<SessionModel>> GetPlanningSessionsAsync(string? trackId, string? programId, string? niveau, string? groupId, string? teacherId);
    Task<string?> GetSessionTypeIdByLabelAsync(string label);
    Task<string?> GetSessionStatusIdByLabelAsync(string label);
    Task<bool> CourseExistsAsync(string courseId);
    Task<bool> RoomExistsAsync(string roomId);
    Task<IReadOnlyList<SessionModel>> GetDeletedAsync();
}