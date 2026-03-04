using System.Collections.Generic;
using System.Threading.Tasks;
using HP2.Application.DTOs.RoomDtos;

namespace HP2.Application.Contracts
{
    public interface IRoomRepository : IAsyncRepository<RoomModel>
    {
        Task<IReadOnlyList<RoomModel?>> GetRoomsByBuildingIdAsync(string buildingId);

    }
}