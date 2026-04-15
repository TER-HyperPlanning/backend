using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class BuildingService : IBuildingService
{
    private readonly IBuildingRepository _buildingRepository;

    public BuildingService(IBuildingRepository buildingRepository)
    {
        _buildingRepository = buildingRepository;
    }

    public async Task<BuildingModel> CreateBuildingAsync(BuildingModel building)
    {
        return await _buildingRepository.AddAsync(building);
    }

    public async Task<BuildingModel?> GetBuildingByIdAsync(string id)
    {
        return await _buildingRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<BuildingModel>> GetAllBuildingsAsync()
    {
        return await _buildingRepository.GetAllAsync();
    }

    public async Task UpdateBuildingAsync(BuildingModel building)
    {
        await _buildingRepository.UpdateAsync(building);
    }

    public async Task DeleteBuildingAsync(string id)
    {
        await _buildingRepository.DeleteAsync(id);
    }
}
