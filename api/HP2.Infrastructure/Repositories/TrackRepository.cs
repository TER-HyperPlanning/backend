using HP2.Application.Contracts;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class TrackRepository : ITrackRepository
{
    private readonly TerHyperplanningContext _dbContext;

    public TrackRepository(TerHyperplanningContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> ExistsAsync(string trackId)
    {
        return await _dbContext.Tracks.AnyAsync(t => t.TrackId == trackId);
    }
}