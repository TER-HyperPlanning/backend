using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Domain.Enums;

namespace HP2.Application;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    private readonly IUserRepository _userRepository;

    public StudentService(IStudentRepository studentRepository, IUserRepository userRepository)
    {
        _studentRepository = studentRepository;
        _userRepository = userRepository;
    }

    public async Task<StudentModel> CreateStudentAsync(StudentModel student)
    {
        // StudentModel already inherits from UserModel, so it contains all user properties
        student.Role = UserRole.STUDENT;
        student.CreatedAt = DateTime.UtcNow;
        student.UpdatedAt = DateTime.UtcNow;

        // Save Student (which includes user data)
        return await _studentRepository.AddAsync(student);
    }

    public async Task<StudentModel?> GetStudentByIdAsync(string id)
    {
        return await _studentRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<StudentModel>> GetAllStudentsAsync()
    {
        return await _studentRepository.GetAllAsync();
    }

    public async Task<IEnumerable<StudentModel>> GetDeletedStudentsAsync()
    {
        return await _studentRepository.GetDeletedAsync();
    }

    public async Task UpdateStudentAsync(StudentModel student)
    {
        student.UpdatedAt = DateTime.UtcNow;
        await _studentRepository.UpdateAsync(student);
    }

    public Task DeleteStudentAsync(string id)
    {
        return _studentRepository.DeleteAsync(id);
    }

    public Task<bool> GroupExistsAsync(string groupId)
        => _studentRepository.GroupExistsAsync(groupId);
}
