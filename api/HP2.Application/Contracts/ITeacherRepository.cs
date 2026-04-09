using HP2.Domain.Models;
using HP2.Domain.Enums;

namespace HP2.Application.Contracts;

public interface ITeacherRepository : IAsyncRepository<TeacherModel>
{
    Task<TeacherModel?> GetByEmailAsync(string email);
    Task<TeacherModel?> GetByMatriculeAsync(string matricule);
    Task<IReadOnlyList<TeacherModel>> GetDeletedAsync();
    Task<bool> HasAvailabilitiesAsync(string id); 
    Task<IEnumerable<TeacherModel>> SearchAsync(string query);
    Task<IEnumerable<TeacherModel>> FilterByTitleAsync(TeacherTitle title);
}