using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IStudentRepository : IAsyncRepository<StudentModel>
{
    Task<StudentModel?> GetByEmailAsync(string email);
    Task<IReadOnlyList<StudentModel>> GetDeletedAsync();
    Task<bool> GroupExistsAsync(string groupId);
}