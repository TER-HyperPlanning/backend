using HP2.Application.Contracts;
using HP2.Application.DTOs.Room;
using HP2.Domain.Models;

namespace HP2.Application;

public class RoomService : IRoomService
{
    private readonly IRoomRepository _repo;

    public RoomService(IRoomRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<RoomResponse>> GetAllAsync()
    {
        var rooms = await _repo.GetAllAsync();

        return rooms.Select(r => new RoomResponse
        {
            RoomId = r.RoomId,
            RoomNumber = r.RoomNumber,
            Capacity = r.Capacity,
            IsAvailable = r.IsAvailable,
            BuildingId = r.BuildingId,
            RoomTypeId = r.RoomTypeId
        }).ToList();
    }

    public async Task<RoomResponse?> GetByIdAsync(string id)
    {
        var r = await _repo.GetByIdAsync(id);
        if (r == null) return null;

        return new RoomResponse
        {
            RoomId = r.RoomId,
            RoomNumber = r.RoomNumber,
            Capacity = r.Capacity,
            IsAvailable = r.IsAvailable,
            BuildingId = r.BuildingId,
            RoomTypeId = r.RoomTypeId
        };
    }

    public async Task<RoomResponse> CreateAsync(CreateRoomRequest request)
    {
        var room = new RoomModel
        {
            RoomId = Guid.NewGuid().ToString(),
            RoomNumber = request.RoomNumber,
            Capacity = request.Capacity,
            BuildingId = request.BuildingId,
            RoomTypeId = request.RoomTypeId,
            IsAvailable = request.IsAvailable
        };

        await _repo.AddAsync(room);

        return new RoomResponse
        {
            RoomId = room.RoomId,
            RoomNumber = room.RoomNumber,
            Capacity = room.Capacity,
            IsAvailable = room.IsAvailable,
            BuildingId = room.BuildingId,
            RoomTypeId = room.RoomTypeId
        };
    }

    public async Task<bool> UpdateAsync(string id, UpdateRoomRequest request)
    {
        var room = await _repo.GetByIdAsync(id);
        if (room == null) return false;

        room.RoomNumber = request.RoomNumber;
        room.Capacity = request.Capacity;
        room.BuildingId = request.BuildingId;
        room.RoomTypeId = request.RoomTypeId;
        room.IsAvailable = request.IsAvailable;

        await _repo.UpdateAsync(room);
        return true;
    }

    public async Task<bool> DeleteAsync(string id)
    {
        await _repo.DeleteAsync(id);
        return true;
    }
}