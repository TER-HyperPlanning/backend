using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IStudentService
{
    Task<StudentModel> CreateStudentAsync(StudentModel student);
    Task<IEnumerable<StudentModel>> GetAllStudentsAsync();
    Task<StudentModel?> GetStudentByIdAsync(string id);
    Task UpdateStudentAsync(StudentModel student);
    Task DeleteStudentAsync(string id);
    Task<bool> GroupExistsAsync(string groupId);
}
