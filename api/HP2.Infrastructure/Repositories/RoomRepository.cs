using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class RoomRepository : RepositoryBase<RoomModel>, IRoomRepository
{
    public RoomRepository(TerHyperplanningContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }

    public override async Task<IReadOnlyList<RoomModel>> GetAllAsync()
    {
        var rooms = await _dbContext.Rooms
            .Include(r => r.Building)
            .Include(r => r.RoomType)
            .AsNoTracking()
            .ToListAsync();

        return rooms.Select(r => new RoomModel
        {
            RoomId = r.RoomId,
            RoomNumber = r.RoomNumber,
            Capacity = r.Capacity,
            IsAvailable = r.IsAvailable ?? true,
            BuildingId = r.BuildingId,
            RoomTypeId = r.RoomTypeId
        }).ToList();
    }

    public override async Task<RoomModel?> GetByIdAsync(string id)
    {
        var r = await _dbContext.Rooms
            .Include(r => r.Building)
            .Include(r => r.RoomType)
            .AsNoTracking()
            .FirstOrDefaultAsync(r => r.RoomId == id);

        if (r == null) return null;

        return new RoomModel
        {
            RoomId = r.RoomId,
            RoomNumber = r.RoomNumber,
            Capacity = r.Capacity,
            IsAvailable = r.IsAvailable ?? true,
            BuildingId = r.BuildingId,
            RoomTypeId = r.RoomTypeId
        };
    }

    public async Task<bool> RoomNumberExistsAsync(string roomNumber, string? excludeRoomId = null)
        => await _dbContext.Rooms.AnyAsync(r =>
            r.RoomNumber == roomNumber &&
            (excludeRoomId == null || r.RoomId != excludeRoomId));

    public async Task<int> GetMinCapacityRequiredAsync(string roomId)
    {
        // Nombre d'étudiants dans les groupes des sessions déjà planifiées dans cette salle
        return await _dbContext.Sessions
            .Where(s => s.RoomId == roomId)
            .SelectMany(s => s.Groups)
            .SelectMany(g => g.Students)
            .CountAsync();
    }

    public override async Task<RoomModel> AddAsync(RoomModel roomModel)
    {
        var entity = new Room
        {
            RoomId = Guid.NewGuid().ToString(),
            RoomNumber = roomModel.RoomNumber,
            Capacity = roomModel.Capacity,
            IsAvailable = roomModel.IsAvailable,
            BuildingId = roomModel.BuildingId,
            RoomTypeId = roomModel.RoomTypeId
        };

        await _dbContext.Rooms.AddAsync(entity);
        await _dbContext.SaveChangesAsync();

        roomModel.RoomId = entity.RoomId;
        return roomModel;
    }

    public override async Task UpdateAsync(RoomModel roomModel)
    {
        var entity = await _dbContext.Rooms
            .FirstOrDefaultAsync(r => r.RoomId == roomModel.RoomId);

        if (entity == null) return;

        entity.RoomNumber = roomModel.RoomNumber;
        entity.Capacity = roomModel.Capacity;
        entity.IsAvailable = roomModel.IsAvailable;
        entity.BuildingId = roomModel.BuildingId;
        entity.RoomTypeId = roomModel.RoomTypeId;

        await _dbContext.SaveChangesAsync();
    }

    public override async Task DeleteAsync(string id)
    {
        var entity = await _dbContext.Rooms.FirstOrDefaultAsync(r => r.RoomId == id);
        if (entity == null) return;

        _dbContext.Rooms.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }
}