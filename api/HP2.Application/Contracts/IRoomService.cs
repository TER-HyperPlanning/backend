using System.Collections.Generic;
using System.Threading.Tasks;
using HP2.Application.DTOs.RoomDtos;

namespace HP2.Application.Contracts
{
    public interface IRoomService
    {
        Task<IEnumerable<RoomResponseDto>> GetAllRoomsAsync();
        Task<RoomResponseDto> GetRoomByIdAsync(int id);
        Task<IEnumerable<RoomResponseDto>> GetRoomsByBuildingIdAsync(int buildingId);
        Task<RoomResponseDto> CreateRoomAsync(RoomRequestDto roomDto);
        Task<RoomResponseDto> UpdateRoomAsync(int id, RoomRequestDto roomDto);
        Task DeleteRoomAsync(int id);
    }
}