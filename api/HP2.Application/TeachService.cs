using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class TeachService : ITeachService
{
    private readonly ITeachRepository _repository;

    public TeachService(ITeachRepository repository)
    {
        _repository = repository;
    }

    public Task<TeachModel> AddAsync(TeachModel model) => _repository.AddAsync(model);

    public Task<TeachModel> UpdateAsync(string currentSessionId, string currentTeacherId, TeachModel model)
        => _repository.UpdateAsync(currentSessionId, currentTeacherId, model);

    public Task<bool> DeleteAsync(string sessionId, string teacherId) => _repository.DeleteAsync(sessionId, teacherId);

    public Task<IReadOnlyList<TeachModel>> GetAllAsync() => _repository.GetAllAsync();

    public Task<IReadOnlyList<TeachModel>> GetBySessionIdAsync(string sessionId) => _repository.GetBySessionIdAsync(sessionId);

    public Task<IReadOnlyList<TeachModel>> GetByTeacherIdAsync(string teacherId) => _repository.GetByTeacherIdAsync(teacherId);

    public Task<bool> ExistsAsync(string sessionId, string teacherId) => _repository.ExistsAsync(sessionId, teacherId);

    public Task<bool> SessionExistsAsync(string sessionId) => _repository.SessionExistsAsync(sessionId);

    public Task<bool> TeacherExistsAsync(string teacherId) => _repository.TeacherExistsAsync(teacherId);
}
