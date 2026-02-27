using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class AvailabilityService : IAvailabilityService
{
    private readonly IAvailabilityRepository _repository;

    public AvailabilityService(IAvailabilityRepository repository)
    {
        _repository = repository;
    }

    public async Task<AvailabilityModel> CreateAsync(AvailabilityModel model)
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

        return await _repository.AddAsync(model);
    }

    public async Task UpdateAsync(string id, AvailabilityModel model)
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
    }

    public async Task DeleteAsync(string id)
    {
        await _repository.DeleteAsync(id);
    }

    public async Task<IReadOnlyList<AvailabilityModel>> GetByTeacherAsync(string teacherId)
    {
        return await _repository.GetByTeacherAsync(teacherId);
    }

    private void Validate(AvailabilityModel model)
    {
        if (model.StartDate == null || model.EndDate == null)
            throw new InvalidOperationException("StartDate and EndDate are required.");

        if (model.StartDate > model.EndDate)
            throw new InvalidOperationException("StartDate must be before EndDate.");

        if (model.StartTime >= model.EndTime)
            throw new InvalidOperationException("StartTime must be before EndTime.");
    }
}