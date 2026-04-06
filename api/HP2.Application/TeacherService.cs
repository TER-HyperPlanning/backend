using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Domain.Enums;

namespace HP2.Application;

public class TeacherService : ITeacherService
{
    private readonly ITeacherRepository _teacherRepository;
    private readonly IUserRepository _userRepository;

    public TeacherService(ITeacherRepository teacherRepository, IUserRepository userRepository)
    {
        _teacherRepository = teacherRepository;
        _userRepository = userRepository;
    }

    public async Task<TeacherModel> CreateTeacherAsync(TeacherModel teacher)
    {
        // TeacherModel already inherits from UserModel, so it contains all user properties
        teacher.Role = UserRole.TEACHER;
        teacher.CreatedAt = DateTime.UtcNow;
        teacher.UpdatedAt = DateTime.UtcNow;

        // Save Teacher (which includes user data)
        return await _teacherRepository.AddAsync(teacher);
    }

    public async Task<TeacherModel?> GetTeacherByIdAsync(string id)
    {
        return await _teacherRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<TeacherModel>> GetAllTeachersAsync()
    {
        return await _teacherRepository.GetAllAsync();
    }

    public async Task UpdateTeacherAsync(TeacherModel teacher)
    {
        teacher.UpdatedAt = DateTime.UtcNow;
        await _teacherRepository.UpdateAsync(teacher);
    }

    public async Task DeleteTeacherAsync(string id)
    {
        await _teacherRepository.DeleteAsync(id);
    }

    public async Task<bool> HasAvailabilitiesAsync(string id)
    {
        return await _teacherRepository.HasAvailabilitiesAsync(id);
    }

    public async Task<IEnumerable<TeacherModel>> SearchAsync(string query)
    {
        return await _teacherRepository.SearchAsync(query);
    }

    public async Task<IEnumerable<TeacherModel>> FilterByTitleAsync(TeacherTitle title)
    {
        return await _teacherRepository.FilterByTitleAsync(title);
    }
}