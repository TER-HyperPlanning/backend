using HP2.Application.DTOs.Room;

namespace HP2.Application.Contracts
{
    public interface IRoomService
    {
        Task<List<RoomResponse>> GetAllAsync();
        Task<RoomResponse?> GetByIdAsync(string id);
        Task<RoomResponse> CreateAsync(CreateRoomRequest request);
        Task<bool> UpdateAsync(string id, UpdateRoomRequest request);
        Task<bool> DeleteAsync(string id);
    }
}