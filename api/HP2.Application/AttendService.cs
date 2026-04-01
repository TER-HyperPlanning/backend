using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class AttendService : IAttendService
{
    private readonly IAttendRepository _repository;

    public AttendService(IAttendRepository repository)
    {
        _repository = repository;
    }

    public Task<AttendModel> AddAsync(AttendModel model) => _repository.AddAsync(model);

    public Task<AttendModel> UpdateAsync(string currentGroupId, string currentSessionId, AttendModel model)
        => _repository.UpdateAsync(currentGroupId, currentSessionId, model);

    public Task<bool> DeleteAsync(string groupId, string sessionId) => _repository.DeleteAsync(groupId, sessionId);

    public Task<IReadOnlyList<AttendModel>> GetAllAsync() => _repository.GetAllAsync();

    public Task<IReadOnlyList<AttendModel>> GetByGroupIdAsync(string groupId) => _repository.GetByGroupIdAsync(groupId);

    public Task<IReadOnlyList<AttendModel>> GetBySessionIdAsync(string sessionId) => _repository.GetBySessionIdAsync(sessionId);

    public Task<bool> ExistsAsync(string groupId, string sessionId) => _repository.ExistsAsync(groupId, sessionId);

    public Task<bool> GroupExistsAsync(string groupId) => _repository.GroupExistsAsync(groupId);

    public Task<bool> SessionExistsAsync(string sessionId) => _repository.SessionExistsAsync(sessionId);
}
