using HP2.Domain.Models;
using System.Collections.Generic;

namespace HP2.Application.Contracts;

public interface IStudentRepository : IAsyncRepository<StudentModel>
{
    Task<StudentModel?> GetByEmailAsync(string email);
    Task<IReadOnlyList<StudentModel>> GetDeletedAsync();
    Task<IReadOnlyList<StudentModel>> GetByGroupIdAsync(string groupId);
    Task<bool> GroupExistsAsync(string groupId);
}