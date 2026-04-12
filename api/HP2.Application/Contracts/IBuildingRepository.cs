using HP2.Domain.Models;
using HP2.Application.DTOs.Session;
using System;

namespace HP2.Application.Contracts;

public interface IBuildingRepository : IAsyncRepository<BuildingModel>
{
    Task<IReadOnlyList<BuildingModel>> GetBuildingsAsync(string? query);
    Task<BlockingSessionInfo?> GetFirstNotYetPassedSessionUsingBuildingRoomsAsync(string buildingId, DateTime referenceDateTime);
    Task<IReadOnlyList<BuildingModel>> GetDeletedAsync();
}
