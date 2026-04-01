using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ITeachRepository
{
    Task<TeachModel> AddAsync(TeachModel model);
    Task<TeachModel> UpdateAsync(string currentSessionId, string currentTeacherId, TeachModel model);
    Task<bool> DeleteAsync(string sessionId, string teacherId);
    Task<IReadOnlyList<TeachModel>> GetAllAsync();
    Task<IReadOnlyList<TeachModel>> GetBySessionIdAsync(string sessionId);
    Task<IReadOnlyList<TeachModel>> GetByTeacherIdAsync(string teacherId);
    Task<bool> ExistsAsync(string sessionId, string teacherId);
    Task<bool> SessionExistsAsync(string sessionId);
    Task<bool> TeacherExistsAsync(string teacherId);
}
