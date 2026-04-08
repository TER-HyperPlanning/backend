using HP2.Domain.Models;
using HP2.Domain.Enums;

namespace HP2.Application.Contracts;

public interface ITeacherService
{
    Task<TeacherModel> CreateTeacherAsync(TeacherModel teacher);
    Task<IEnumerable<TeacherModel>> GetAllTeachersAsync();
    Task<IEnumerable<TeacherModel>> GetDeletedTeachersAsync();
    Task<TeacherModel?> GetTeacherByIdAsync(string id);
    Task UpdateTeacherAsync(TeacherModel teacher);
    Task DeleteTeacherAsync(string id);
    Task<bool> HasAvailabilitiesAsync(string id);
    Task<IEnumerable<TeacherModel>> SearchAsync(string query);
    Task<IEnumerable<TeacherModel>> FilterByTitleAsync(TeacherTitle title);
}