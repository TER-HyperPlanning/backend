using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class RoomRepository : IRoomRepository
{
    private readonly TerHyperplanningContext _context;

    public RoomRepository(TerHyperplanningContext context)
    {
        _context = context;
    }

    public async Task<List<RoomModel>> GetAllAsync()
    {
        return await _context.Rooms
            .Select(r => new RoomModel
            {
                RoomId = r.RoomId,
                RoomNumber = r.RoomNumber,
                IsAvailable = r.IsAvailable ?? true,
                Capacity = r.Capacity,
                BuildingId = r.BuildingId,
                RoomTypeId = r.RoomTypeId
            })
            .ToListAsync();
    }

    public async Task<RoomModel?> GetByIdAsync(string id)
    {
        return await _context.Rooms
            .Where(r => r.RoomId == id)
            .Select(r => new RoomModel
            {
                RoomId = r.RoomId,
                RoomNumber = r.RoomNumber,
                IsAvailable = r.IsAvailable ?? true,
                Capacity = r.Capacity,
                BuildingId = r.BuildingId,
                RoomTypeId = r.RoomTypeId
            })
            .FirstOrDefaultAsync();
    }

    public async Task<RoomModel?> GetByRoomNumberAsync(string roomNumber)
    {
        return await _context.Rooms
            .Where(r => r.RoomNumber == roomNumber)
            .Select(r => new RoomModel
            {
                RoomId = r.RoomId,
                RoomNumber = r.RoomNumber,
                IsAvailable = r.IsAvailable ?? true,
                Capacity = r.Capacity,
                BuildingId = r.BuildingId,
                RoomTypeId = r.RoomTypeId
            })
            .FirstOrDefaultAsync();
    }

    public async Task AddAsync(RoomModel room)
    {
        var entity = new Room
        {
            RoomId = room.RoomId,
            RoomNumber = room.RoomNumber,
            IsAvailable = room.IsAvailable,
            Capacity = room.Capacity,
            BuildingId = room.BuildingId,
            RoomTypeId = room.RoomTypeId
        };

        await _context.Rooms.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(RoomModel room)
    {
        var entity = await _context.Rooms
            .FirstOrDefaultAsync(r => r.RoomId == room.RoomId);

        if (entity == null) return;

        entity.RoomNumber = room.RoomNumber;
        entity.IsAvailable = room.IsAvailable;
        entity.Capacity = room.Capacity;
        entity.BuildingId = room.BuildingId;
        entity.RoomTypeId = room.RoomTypeId;

        _context.Rooms.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(string roomId)
    {
        var entity = await _context.Rooms
            .FirstOrDefaultAsync(r => r.RoomId == roomId);

        if (entity != null)
        {
            _context.Rooms.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}