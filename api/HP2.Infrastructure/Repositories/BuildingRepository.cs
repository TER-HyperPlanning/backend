using AutoMapper;
using HP2.Application.Contracts;
using HP2.Application.DTOs.Session;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class BuildingRepository : RepositoryBase<BuildingModel>, IBuildingRepository
{
    public BuildingRepository(TerHyperplanningContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }

    public override async Task<IReadOnlyList<BuildingModel>> GetAllAsync()
    {
        var buildings = await _dbContext.Buildings.AsNoTracking().ToListAsync();
        return _mapper.Map<List<BuildingModel>>(buildings);
    }

    public async Task<IReadOnlyList<BuildingModel>> GetDeletedAsync()
    {
        var buildings = await _dbContext.Buildings
            .IgnoreQueryFilters()
            .AsNoTracking()
            .Where(b => b.IsDeleted)
            .ToListAsync();

        return _mapper.Map<List<BuildingModel>>(buildings);
    }

    public override async Task<BuildingModel?> GetByIdAsync(string id)
    {
        var building = await _dbContext.Buildings.AsNoTracking()
            .FirstOrDefaultAsync(b => b.BuildingId == id);

        return building != null ? _mapper.Map<BuildingModel>(building) : null;
    }

    public override async Task<BuildingModel> AddAsync(BuildingModel buildingModel)
    {
        var entity = new Building
        {
            BuildingId = Guid.NewGuid().ToString(),
            Name = buildingModel.Name,
            IsDeleted = false,
            DeletedAt = null
        };

        await _dbContext.Buildings.AddAsync(entity);
        await _dbContext.SaveChangesAsync();

        buildingModel.Id = entity.BuildingId;
        return buildingModel;
    }

    public override async Task UpdateAsync(BuildingModel buildingModel)
    {
        var building = await _dbContext.Buildings
            .FirstOrDefaultAsync(b => b.BuildingId == buildingModel.Id);

        if (building == null) return;

        building.Name = buildingModel.Name;
        building.IsDeleted = buildingModel.IsDeleted;
        building.DeletedAt = buildingModel.DeletedAt;

        await _dbContext.SaveChangesAsync();
    }

    public override async Task DeleteAsync(string id)
    {
        await base.DeleteAsync(id);
    }

    public Task<BlockingSessionInfo?> GetFirstNotYetPassedSessionUsingBuildingRoomsAsync(string buildingId, DateTime referenceDateTime)
    {
        var referenceDate = referenceDateTime.Date;
        var referenceTime = referenceDateTime.TimeOfDay;

        return _dbContext.Sessions
            .AsNoTracking()
            .Where(s => s.Room.BuildingId == buildingId
                        && (s.Date > referenceDate
                            || (s.Date == referenceDate && s.EndTime > referenceTime)))
            .OrderBy(s => s.Date)
            .ThenBy(s => s.StartTime)
            .Select(s => new BlockingSessionInfo
            {
                SessionId = s.SessionId,
                StartDateTime = s.Date.Date + s.StartTime,
                EndDateTime = s.Date.Date + s.EndTime,
                RoomId = s.RoomId,
                RoomNumber = s.Room.RoomNumber,
                CourseId = s.CourseId,
                CourseName = s.Course.Name
            })
            .FirstOrDefaultAsync();
    }
}
