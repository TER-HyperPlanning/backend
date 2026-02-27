using System.Collections.Generic;
using System.Threading.Tasks;
using HP2.Application.Contracts;
using HP2.Application.DTOs.RoomDtos;

namespace HP2.Application.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<IEnumerable<RoomResponseDto>> GetAllRoomsAsync()
        {
            return await _roomRepository.GetAllRoomsAsync();
        }

        public async Task<RoomResponseDto> GetRoomByIdAsync(int id)
        {
            return await _roomRepository.GetRoomByIdAsync(id);
        }

        public async Task<IEnumerable<RoomResponseDto>> GetRoomsByBuildingIdAsync(int buildingId)
        {
            return await _roomRepository.GetRoomsByBuildingIdAsync(buildingId);
        }

        public async Task<RoomResponseDto> CreateRoomAsync(RoomRequestDto roomDto)
        {
            return await _roomRepository.CreateRoomAsync(roomDto);
        }

        public async Task<RoomResponseDto> UpdateRoomAsync(int id, RoomRequestDto roomDto)
        {
            return await _roomRepository.UpdateRoomAsync(id, roomDto);
        }

        public async Task DeleteRoomAsync(int id)
        {
            await _roomRepository.DeleteRoomAsync(id);
        }


    }
}