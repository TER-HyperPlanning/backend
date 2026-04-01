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
        => await _context.Set<RoomModel>().ToListAsync();

    public async Task<RoomModel?> GetByIdAsync(string id)
        => await _context.Set<RoomModel>()
            .FirstOrDefaultAsync(r => r.RoomId == id);

    public async Task AddAsync(RoomModel room)
    {
        await _context.AddAsync(room);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(RoomModel room)
    {
        _context.Update(room);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(string id)
    {
        var room = await GetByIdAsync(id);
        if (room != null)
        {
            _context.Remove(room);
            await _context.SaveChangesAsync();
        }
    }
}