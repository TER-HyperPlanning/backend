using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IAttendRepository
{
    Task<AttendModel> AddAsync(AttendModel model);
    Task<AttendModel> UpdateAsync(string currentGroupId, string currentSessionId, AttendModel model);
    Task<bool> DeleteAsync(string groupId, string sessionId);
    Task<IReadOnlyList<AttendModel>> GetAllAsync();
    Task<IReadOnlyList<AttendModel>> GetByGroupIdAsync(string groupId);
    Task<IReadOnlyList<AttendModel>> GetBySessionIdAsync(string sessionId);
    Task<bool> ExistsAsync(string groupId, string sessionId);
    Task<bool> GroupExistsAsync(string groupId);
    Task<bool> SessionExistsAsync(string sessionId);
    Task<IEnumerable<string>> GetAffectedUserIdsAsync(string groupId);
}
