using System.Collections.Generic;
using System.Threading.Tasks;
using HP2.Application.DTOs.RoomDtos;
using System;
using HP2.Application.DTOs.Session;
using HP2.Domain.Enums;

namespace HP2.Application.Contracts
{
    public interface IRoomRepository : IAsyncRepository<RoomModel>
    {
        Task<IReadOnlyList<RoomModel>> GetRoomsByBuildingIdAsync(string buildingId);
        Task<IReadOnlyList<RoomModel>> GetRoomsAsync(IEnumerable<RoomTypeEnum> types, string? query);
        Task<BlockingSessionInfo?> GetFirstNotYetPassedSessionAsync(string roomId, DateTime referenceDateTime);
        Task<IReadOnlyList<RoomModel>> GetDeletedAsync();

    }
}