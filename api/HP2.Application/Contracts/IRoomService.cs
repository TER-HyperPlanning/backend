using System.Collections.Generic;
using System.Threading.Tasks;
using HP2.Application.DTOs.RoomDtos;

namespace HP2.Application.Contracts
{
    public interface IRoomService
    {
        Task<IEnumerable<RoomModel>> GetAllRoomsAsync();
        Task<IEnumerable<RoomModel>> GetDeletedRoomsAsync();
        Task<RoomModel?> GetRoomByIdAsync(string id);
        Task<IEnumerable<RoomModel>> GetRoomsByBuildingIdAsync(string buildingId);
        Task<RoomModel> CreateRoomAsync(RoomModel roomDto);
        Task UpdateRoomAsync(RoomModel roomDto);
        Task DeleteRoomAsync(string id);
    }
}