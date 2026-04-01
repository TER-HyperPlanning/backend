using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class RoomService : IRoomService
{
    private readonly IRoomRepository _roomRepository;

    public RoomService(IRoomRepository roomRepository)
    {
        _roomRepository = roomRepository;
    }

    public Task<List<RoomModel>> GetAllAsync()
        => _roomRepository.GetAllAsync();

    public Task<RoomModel?> GetByIdAsync(string id)
        => _roomRepository.GetByIdAsync(id);

    public Task CreateAsync(RoomModel room)
        => _roomRepository.AddAsync(room);

    public Task UpdateAsync(RoomModel room)
        => _roomRepository.UpdateAsync(room);

    public Task DeleteAsync(string roomId)
        => _roomRepository.DeleteAsync(roomId);
}