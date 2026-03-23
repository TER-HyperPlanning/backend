using HP2.Application.Contracts;
using HP2.Application.DTOs.Assign;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories;

public class AssignRepository : IAssignRepository
{
    private readonly TerHyperplanningContext _context;

    public AssignRepository(TerHyperplanningContext context)
    {
        _context = context;
    }

    public async Task<List<AssignResponse>> GetAllAsync()
    {
        return await _context.Assigns
            .Select(a => new AssignResponse
            {
                TrackId = a.TrackId,
                CourseId = a.CourseId,
                HourlyVolume = a.HourlyVolume
            })
            .ToListAsync();
    }

    public async Task<AssignResponse?> GetByIdsAsync(string trackId, string courseId)
    {
        var assign = await _context.Assigns
            .FirstOrDefaultAsync(a => a.TrackId == trackId && a.CourseId == courseId);

        if (assign == null) return null;

        return new AssignResponse
        {
            TrackId = assign.TrackId,
            CourseId = assign.CourseId,
            HourlyVolume = assign.HourlyVolume
        };
    }

    public async Task<bool> CreateAsync(string trackId, string courseId, int hourlyVolume)
    {
        var entity = new Assign
        {
            TrackId = trackId,
            CourseId = courseId,
            HourlyVolume = hourlyVolume
        };

        _context.Assigns.Add(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateAsync(string trackId, string courseId, int hourlyVolume)
    {
        var assign = await _context.Assigns
            .FirstOrDefaultAsync(a => a.TrackId == trackId && a.CourseId == courseId);

        if (assign == null) return false;

        assign.HourlyVolume = hourlyVolume;

        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(string trackId, string courseId)
    {
        var assign = await _context.Assigns
            .FirstOrDefaultAsync(a => a.TrackId == trackId && a.CourseId == courseId);

        if (assign == null) return false;

        _context.Assigns.Remove(assign);
        return await _context.SaveChangesAsync() > 0;
    }
}