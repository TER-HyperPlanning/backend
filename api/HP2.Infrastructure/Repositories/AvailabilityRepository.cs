using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class AvailabilityRepository 
    : RepositoryBase<AvailabilityModel>, IAvailabilityRepository
{
    public AvailabilityRepository(TerHyperplanningContext dbContext, IMapper mapper)
        : base(dbContext, mapper)
    {
    }

    public override async Task<IReadOnlyList<AvailabilityModel>> GetAllAsync()
    {
        var entities = await _dbContext.Availabilities.ToListAsync();
        return _mapper.Map<IReadOnlyList<AvailabilityModel>>(entities);
    }

    public override async Task<AvailabilityModel?> GetByIdAsync(string id)
    {
        var entity = await _dbContext.Availabilities
            .FirstOrDefaultAsync(a => a.AvailabilityId == id);

        return entity == null ? null : _mapper.Map<AvailabilityModel>(entity);
    }

    public async Task<IReadOnlyList<AvailabilityModel>> GetByTeacherAsync(string teacherId)
    {
        var entities = await _dbContext.Availabilities
            .Where(a => a.TeacherId == teacherId)
            .ToListAsync();

        return _mapper.Map<IReadOnlyList<AvailabilityModel>>(entities);
    }

    public override async Task<AvailabilityModel> AddAsync(AvailabilityModel model)
    {
        var entity = _mapper.Map<Availability>(model);
        entity.AvailabilityId = Guid.NewGuid().ToString();

        _dbContext.Availabilities.Add(entity);
        await _dbContext.SaveChangesAsync();

        return _mapper.Map<AvailabilityModel>(entity);
    }

    public override async Task UpdateAsync(AvailabilityModel model)
    {
        var entity = await _dbContext.Availabilities
            .FirstOrDefaultAsync(a => a.AvailabilityId == model.Id);

        if (entity == null) return;

        _mapper.Map(model, entity);

        await _dbContext.SaveChangesAsync();
    }

    public override async Task DeleteAsync(string id)
    {
        var entity = await _dbContext.Availabilities
            .FirstOrDefaultAsync(a => a.AvailabilityId == id);

        if (entity == null) return;

        _dbContext.Availabilities.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    //  Détection de conflit intelligente
    public async Task<bool> HasConflictAsync(
        string teacherId,
        string weekDayId,
        TimeSpan startTime,
        TimeSpan endTime,
        DateTime startDate,
        DateTime endDate,
        string? excludeId = null)
    {
        var query = _dbContext.Availabilities
            .Where(a => a.TeacherId == teacherId &&
                        a.WeekdayId == weekDayId);

        if (!string.IsNullOrWhiteSpace(excludeId))
            query = query.Where(a => a.AvailabilityId != excludeId);

        var existing = await query.ToListAsync();

        foreach (var a in existing)
        {
            bool timeOverlap =
                startTime < a.EndTime &&
                a.StartTime < endTime;

            bool dateOverlap =
                startDate <= a.EndDate &&
                a.StartDate <= endDate;

            if (timeOverlap && dateOverlap)
                return true;
        }

        return false;
    }
}