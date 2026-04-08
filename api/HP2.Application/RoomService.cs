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

        public async Task<IEnumerable<RoomModel>> GetAllRoomsAsync()
        {
            return await _roomRepository.GetAllAsync();
        }

        public async Task<RoomModel?> GetRoomByIdAsync(string id)
        {

            return await _roomRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<RoomModel>> GetRoomsByBuildingIdAsync(string buildingId)
        {
            return await _roomRepository.GetRoomsByBuildingIdAsync(buildingId) ?? new List<RoomModel>();

        }

        public async Task<RoomModel> CreateRoomAsync(RoomModel roomDto)
        {

            return await _roomRepository.AddAsync(roomDto);
        }

        public async Task UpdateRoomAsync(RoomModel roomDto)
        {
            await _roomRepository.UpdateAsync(roomDto);
        }

        public async Task DeleteRoomAsync(string id)
        {
            await _roomRepository.DeleteAsync(id);
        }


    }
}