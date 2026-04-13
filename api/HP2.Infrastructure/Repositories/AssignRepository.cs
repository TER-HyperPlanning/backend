using HP2.Application.Contracts;
using HP2.Application.DTOs.Assign;
using AutoMapper;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace HP2.Infrastructure.Repositories;

public class AssignRepository : RepositoryBase<AssignModel>, IAssignRepository
{
    private const char CompositeKeySeparator = '|';

    public AssignRepository(TerHyperplanningContext context, IMapper mapper) : base(context, mapper)
    {
    }

    private static string BuildCompositeKey(string trackId, string courseId)
    {
        return $"{trackId}{CompositeKeySeparator}{courseId}";
    }

    private static bool TryParseCompositeKey(string id, out string trackId, out string courseId)
    {
        trackId = string.Empty;
        courseId = string.Empty;

        if (string.IsNullOrWhiteSpace(id))
        {
            return false;
        }

        var parts = id.Split(CompositeKeySeparator, 2, StringSplitOptions.None);
        if (parts.Length != 2 || string.IsNullOrWhiteSpace(parts[0]) || string.IsNullOrWhiteSpace(parts[1]))
        {
            return false;
        }

        trackId = parts[0];
        courseId = parts[1];
        return true;
    }

    public override async Task<AssignModel?> GetByIdAsync(string id)
    {
        if (!TryParseCompositeKey(id, out var trackId, out var courseId))
        {
            return null;
        }

        var assign = await _dbContext.Assigns
            .FirstOrDefaultAsync(a => a.TrackId == trackId && a.CourseId == courseId);

        if (assign == null)
        {
            return null;
        }

        return new AssignModel
        {
            TrackId = assign.TrackId,
            CourseId = assign.CourseId,
            IsDeleted = assign.IsDeleted,
            DeletedAt = assign.DeletedAt
        };
    }

    public override async Task UpdateAsync(AssignModel assignModel)
    {
        var assign = await _dbContext.Assigns
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(a => a.TrackId == assignModel.TrackId && a.CourseId == assignModel.CourseId);

        if (assign == null)
        {
            return;
        }

        assign.IsDeleted = assignModel.IsDeleted;
        assign.DeletedAt = assignModel.DeletedAt;

        await _dbContext.SaveChangesAsync();
    }

    public new async Task<List<AssignResponse>> GetAllAsync()
    {
        return await _dbContext.Assigns
            .Select(a => new AssignResponse
            {
                TrackId = a.TrackId,
                CourseId = a.CourseId,
                HourlyVolume = a.HourlyVolume,
                DeletedAt = a.DeletedAt
            })
            .ToListAsync();
    }

    public async Task<AssignResponse?> GetByIdsAsync(string trackId, string courseId)
    {
        var assign = await _dbContext.Assigns
            .FirstOrDefaultAsync(a => a.TrackId == trackId && a.CourseId == courseId);

        if (assign == null) return null;

        return new AssignResponse
        {
            TrackId = assign.TrackId,
            CourseId = assign.CourseId,
            HourlyVolume = assign.HourlyVolume,
            DeletedAt = assign.DeletedAt
        };
    }

    public async Task<bool> CreateAsync(string trackId, string courseId, int hourlyVolume)
    {
        var existing = await _dbContext.Assigns
            .IgnoreQueryFilters()
            .FirstOrDefaultAsync(a => a.TrackId == trackId && a.CourseId == courseId);
        
        if (existing != null)
        {
            if (existing.IsDeleted)
            {
                existing.IsDeleted = false;
                existing.DeletedAt = null;
                existing.HourlyVolume = hourlyVolume;

                return await _dbContext.SaveChangesAsync() > 0;
            }
            return false;
        }

        var assign = new Assign
        {
            TrackId = trackId,
            CourseId = courseId,
            HourlyVolume = hourlyVolume
        };
        
        _dbContext.Assigns.Add(assign);
        return await _dbContext.SaveChangesAsync() > 0;

    }

    public async Task<bool> UpdateAsync(string trackId, string courseId, int hourlyVolume)
    {
        var assign = await _dbContext.Assigns
            .FirstOrDefaultAsync(a => a.TrackId == trackId && a.CourseId == courseId);

        if (assign == null) return false;

        assign.HourlyVolume = hourlyVolume;

        return await _dbContext.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(string trackId, string courseId)
    {
        var existing = await _dbContext.Assigns
            .FirstOrDefaultAsync(a => a.TrackId == trackId && a.CourseId == courseId);

        if (existing == null)
        {
            return false;
        }

        await base.DeleteAsync(BuildCompositeKey(trackId, courseId));
        return true;
    }

    public async Task<bool> TrackExistsAsync(string trackId)
    {
        return await _dbContext.Tracks.AnyAsync(t => t.TrackId == trackId);
    }
    
    public async Task<bool> CourseExistsAsync(string courseId)
    {
        return await _dbContext.Courses.AnyAsync(c => c.CourseId == courseId);
    }

    public async Task<List<AssignResponse>> GetDeletedAsync()
{
    return await _dbContext.Assigns
        .IgnoreQueryFilters()
        .Where(a => a.IsDeleted)
        .Select(a => new AssignResponse
        {
            TrackId = a.TrackId,
            CourseId = a.CourseId,
            HourlyVolume = a.HourlyVolume,
            DeletedAt = a.DeletedAt
        })
        .ToListAsync();
}
}