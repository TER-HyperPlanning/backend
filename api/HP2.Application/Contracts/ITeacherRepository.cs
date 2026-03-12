using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface ITeacherRepository : IAsyncRepository<TeacherModel>
{
    Task<TeacherModel?> GetByEmailAsync(string email);
    Task<TeacherModel?> GetByMatriculeAsync(string matricule);
    Task<bool> HasAvailabilitiesAsync(string id); 
}