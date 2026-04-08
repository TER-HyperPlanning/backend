using HP2.Application.Contracts;
using HP2.Application.DTOs.Availability;
using HP2.Domain.Models;

namespace HP2.Application;

public class AvailabilityService : IAvailabilityService
{
    private readonly IAvailabilityRepository _repository;

    public AvailabilityService(IAvailabilityRepository repository)
    {
        _repository = repository;
    }

    public async Task<AvailabilityResponse> CreateAsync(AvailabilityModel model)
    {
        Validate(model);

        bool conflict = await _repository.HasConflictAsync(
            model.TeacherId,
            model.WeekDayId,
            model.StartTime,
            model.EndTime,
            model.StartDate!.Value,
            model.EndDate!.Value);

        if (conflict)
            throw new InvalidOperationException("Conflict detected with existing availability.");

        var created = await _repository.AddAsync(model);
        var response = await _repository.GetResponseByIdAsync(created.Id);

        if (response == null)
            throw new InvalidOperationException("Availability created but could not be retrieved.");

        return response;
    }

    public async Task<AvailabilityResponse> UpdateAsync(string id, AvailabilityModel model)
    {
        Validate(model);

        bool conflict = await _repository.HasConflictAsync(
            model.TeacherId,
            model.WeekDayId,
            model.StartTime,
            model.EndTime,
            model.StartDate!.Value,
            model.EndDate!.Value,
            id);

        if (conflict)
            throw new InvalidOperationException("Conflict detected with existing availability.");

        model.Id = id;
        await _repository.UpdateAsync(model);

        var response = await _repository.GetResponseByIdAsync(id);

        if (response == null)
            throw new InvalidOperationException("Availability updated but could not be retrieved.");

        return response;
    }

    public async Task DeleteAsync(string id)
    {
        await _repository.DeleteAsync(id);
    }

    public async Task<IReadOnlyList<AvailabilityResponse>> GetByTeacherAsync(string teacherId)
    {
        return await _repository.GetByTeacherAsync(teacherId);
    }

    private static void Validate(AvailabilityModel model)
    {
        if (model.StartDate == null || model.EndDate == null)
            throw new InvalidOperationException("StartDate and EndDate are required.");

        if (model.StartDate > model.EndDate)
            throw new InvalidOperationException("StartDate must be before EndDate.");

        if (model.StartTime >= model.EndTime)
            throw new InvalidOperationException("StartTime must be before EndTime.");
    }
}