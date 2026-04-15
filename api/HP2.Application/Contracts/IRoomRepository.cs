using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IRoomRepository
{
    Task<IReadOnlyList<RoomModel>> GetAllAsync();
    Task<RoomModel?> GetByIdAsync(string id);
    Task<bool> RoomNumberExistsAsync(string roomNumber, string? excludeRoomId = null);
    Task<int> GetMinCapacityRequiredAsync(string roomId);
    Task<RoomModel> AddAsync(RoomModel room);
    Task UpdateAsync(RoomModel room);
    Task DeleteAsync(string id);
}