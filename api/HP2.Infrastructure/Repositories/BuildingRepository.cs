using AutoMapper;
using HP2.Application.Contracts;
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
            BuildingId = buildingModel.Id,
            Name = buildingModel.Name
        };

        if (string.IsNullOrWhiteSpace(entity.BuildingId))
        {
            entity.BuildingId = Guid.NewGuid().ToString();
        }

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

        await _dbContext.SaveChangesAsync();
    }

    public override async Task DeleteAsync(string id)
    {
        var building = await _dbContext.Buildings.FirstOrDefaultAsync(b => b.BuildingId == id);
        if (building == null) return;

        _dbContext.Buildings.Remove(building);
        await _dbContext.SaveChangesAsync();
    }
}
