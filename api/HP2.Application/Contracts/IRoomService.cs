using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IRoomService
{
    Task<List<RoomModel>> GetAllAsync();
    Task<RoomModel?> GetByIdAsync(string id);
    Task<RoomModel?> GetByRoomNumberAsync(string roomNumber);
    Task CreateAsync(RoomModel room);
    Task UpdateAsync(RoomModel room);
    Task DeleteAsync(string roomId);
}