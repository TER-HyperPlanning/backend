using HP2.Application.Contracts;
using HP2.Application.Exceptions;
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

    public async Task<IEnumerable<BuildingModel>> GetBuildingsAsync(string? query)
    {
        return await _buildingRepository.GetBuildingsAsync(query);
    }

    public async Task<IEnumerable<BuildingModel>> GetAllBuildingsAsync()
    {
        return await _buildingRepository.GetAllAsync();
    }

    public async Task<IEnumerable<BuildingModel>> GetDeletedBuildingsAsync()
    {
        return await _buildingRepository.GetDeletedAsync();
    }

    public async Task UpdateBuildingAsync(BuildingModel building)
    {
        await _buildingRepository.UpdateAsync(building);
    }

    public async Task DeleteBuildingAsync(string id)
    {
        var blockingSession = await _buildingRepository.GetFirstNotYetPassedSessionUsingBuildingRoomsAsync(id, DateTime.UtcNow);
        if (blockingSession != null)
        {
            throw new DeleteConflictException(
                $"Cannot delete building '{id}' because room '{blockingSession.RoomNumber}' is used by session '{blockingSession.SessionId}' that has not ended yet.",
                blockingSession);
        }

        await _buildingRepository.DeleteAsync(id);
    }
}
