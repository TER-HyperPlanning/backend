using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ITeacherService
{
    Task<TeacherModel> CreateTeacherAsync(TeacherModel teacher);
    Task<IEnumerable<TeacherModel>> GetAllTeachersAsync();
    Task<TeacherModel?> GetTeacherByIdAsync(string id);
    Task UpdateTeacherAsync(TeacherModel teacher);
    Task DeleteTeacherAsync(string id);
    Task<bool> HasAvailabilitiesAsync(string id);
}