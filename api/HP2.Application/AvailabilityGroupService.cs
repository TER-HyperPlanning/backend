using HP2.Application.Contracts;
using HP2.Application.DTOs.Availability;
using HP2.Domain.Models;

namespace HP2.Application;

public class AvailabilityGroupService : IAvailabilityGroupService
{
    private readonly IAvailabilityGroupRepository _repository;

    public AvailabilityGroupService(IAvailabilityGroupRepository repository)
    {
        _repository = repository;
    }

    public async Task<AvailabilityGroupResponse> CreateAsync(AvailabilityGroupModel model)
    {
        var created = await _repository.AddAsync(model);
        var response = await _repository.GetResponseByIdAsync(created.Id);

        if (response == null)
            throw new InvalidOperationException("Availability group created but could not be retrieved.");

        return response;
    }

    public async Task<AvailabilityGroupResponse> UpdateAsync(string id, AvailabilityGroupModel model)
    {
        model.Id = id;
        await _repository.UpdateAsync(model);

        var response = await _repository.GetResponseByIdAsync(id);

        if (response == null)
            throw new InvalidOperationException("Availability group updated but could not be retrieved.");

        return response;
    }

    public async Task DeleteAsync(string id)
    {
        await _repository.DeleteAsync(id);
    }

    public async Task<IReadOnlyList<AvailabilityGroupResponse>> GetByTeacherAsync(string teacherId)
    {
        return await _repository.GetByTeacherAsync(teacherId);
    }

    public async Task<AvailabilityGroupResponse?> GetByIdAsync(string id)
    {
        return await _repository.GetResponseByIdAsync(id);
    }
}
