using System.Collections.Generic;
using System.Threading.Tasks;
using HP2.Application.DTOs.RoomDtos;
using System;
using HP2.Application.DTOs.Session;

namespace HP2.Application.Contracts
{
    public interface IRoomRepository : IAsyncRepository<RoomModel>
    {
        Task<IReadOnlyList<RoomModel>> GetRoomsByBuildingIdAsync(string buildingId);
        Task<BlockingSessionInfo?> GetFirstNotYetPassedSessionAsync(string roomId, DateTime referenceDateTime);
        Task<IReadOnlyList<RoomModel>> GetDeletedAsync();

    }
}