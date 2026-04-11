using AutoMapper;
using HP2.Application.Contracts;
using HP2.Application.DTOs.Availability;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class AvailabilityGroupRepository
    : RepositoryBase<AvailabilityGroupModel>, IAvailabilityGroupRepository
{
    public AvailabilityGroupRepository(TerHyperplanningContext dbContext, IMapper mapper)
        : base(dbContext, mapper)
    {
    }

    public override async Task<IReadOnlyList<AvailabilityGroupModel>> GetAllAsync()
    {
        var entities = await _dbContext.AvailabilityGroups.ToListAsync();
        return _mapper.Map<IReadOnlyList<AvailabilityGroupModel>>(entities);
    }

    public override async Task<AvailabilityGroupModel?> GetByIdAsync(string id)
    {
        var entity = await _dbContext.AvailabilityGroups
            .FirstOrDefaultAsync(g => g.AvailabilityGroupId == id);

        return entity == null ? null : _mapper.Map<AvailabilityGroupModel>(entity);
    }

    public async Task<AvailabilityGroupResponse?> GetResponseByIdAsync(string id)
    {
        var entity = await _dbContext.AvailabilityGroups
            .FirstOrDefaultAsync(g => g.AvailabilityGroupId == id);

        return entity == null ? null : _mapper.Map<AvailabilityGroupResponse>(entity);
    }

    public async Task<IReadOnlyList<AvailabilityGroupResponse>> GetByTeacherAsync(string teacherId)
    {
        var entities = await _dbContext.AvailabilityGroups
            .Where(g => g.TeacherId == teacherId)
            .ToListAsync();

        return _mapper.Map<IReadOnlyList<AvailabilityGroupResponse>>(entities);
    }

    public override async Task<AvailabilityGroupModel> AddAsync(AvailabilityGroupModel model)
    {
        var entity = _mapper.Map<AvailabilityGroup>(model);
        entity.AvailabilityGroupId = Guid.NewGuid().ToString();

        _dbContext.AvailabilityGroups.Add(entity);
        await _dbContext.SaveChangesAsync();

        return _mapper.Map<AvailabilityGroupModel>(entity);
    }

    public override async Task UpdateAsync(AvailabilityGroupModel model)
    {
        var entity = await _dbContext.AvailabilityGroups
            .FirstOrDefaultAsync(g => g.AvailabilityGroupId == model.Id);

        if (entity == null) return;

        entity.NumberOfAvailableDays = model.NumberOfAvailableDays;
        await _dbContext.SaveChangesAsync();
    }

    public override async Task DeleteAsync(string id)
    {
        var entity = await _dbContext.AvailabilityGroups
            .FirstOrDefaultAsync(g => g.AvailabilityGroupId == id);

        if (entity == null) return;

        _dbContext.AvailabilityGroups.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }
}
