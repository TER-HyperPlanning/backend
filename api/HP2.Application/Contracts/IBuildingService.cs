using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IBuildingService
{
    Task<BuildingModel> CreateBuildingAsync(BuildingModel building);
    Task<IEnumerable<BuildingModel>> GetBuildingsAsync(string? query);
    Task<IEnumerable<BuildingModel>> GetAllBuildingsAsync();
    Task<IEnumerable<BuildingModel>> GetDeletedBuildingsAsync();
    Task<BuildingModel?> GetBuildingByIdAsync(string id);
    Task UpdateBuildingAsync(BuildingModel building);
    Task DeleteBuildingAsync(string id);
}
