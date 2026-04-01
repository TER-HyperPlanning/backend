using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IRoomRepository
{
    Task<List<RoomModel>> GetAllAsync();
    Task<RoomModel?> GetByIdAsync(string id);
    Task AddAsync(RoomModel room);
    Task UpdateAsync(RoomModel room);
    Task DeleteAsync(string id);
}