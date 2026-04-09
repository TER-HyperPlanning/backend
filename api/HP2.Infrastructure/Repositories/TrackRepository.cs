using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories
{
    public class TrackRepository : ITrackRepository
    {
        private readonly TerHyperplanningContext _context;

        public TrackRepository(TerHyperplanningContext context)
        {
            _context = context;
        }

        public async Task<List<TrackModel>> GetAllAsync()
        {
            return await _context.Tracks
                .Select(t => new TrackModel {
                    Id = t.TrackId,
                    Name = t.Name,
                    TeacherId = t.TeacherId,
                    ProgramId = t.ProgramId
                })
                .ToListAsync();
        }

        public async Task<TrackModel> GetByIdAsync(string id)
        {
            var t = await _context.Tracks.FindAsync(id);
            if (t == null) return null;

            return new TrackModel {
                Id = t.TrackId,
                Name = t.Name,
                TeacherId = t.TeacherId,
                ProgramId = t.ProgramId
            };
        }

        public async Task<TrackModel> AddAsync(TrackModel model)
        {
            // Validate foreign keys before inserting to provide clear errors
            if (!string.IsNullOrWhiteSpace(model.ProgramId))
            {
                var programExists = await _context.Programs.AnyAsync(p => p.ProgramId == model.ProgramId);
                if (!programExists)
                    throw new ArgumentException($"Program with ID {model.ProgramId} does not exist.");
            }

            if (!string.IsNullOrWhiteSpace(model.TeacherId))
            {
                var teacherExists = await _context.Teachers.AnyAsync(t => t.UserId == model.TeacherId);
                if (!teacherExists)
                    throw new ArgumentException($"Teacher with ID {model.TeacherId} does not exist.");
            }

            var entity = new Track
            {
                TrackId = model.Id ?? Guid.NewGuid().ToString(),
                Name = model.Name,
                TeacherId = model.TeacherId,
                ProgramId = model.ProgramId
            };
            _context.Tracks.Add(entity);
            await _context.SaveChangesAsync();
            model.Id = entity.TrackId;
            return model;
        }

        public async Task<TrackModel> UpdateAsync(TrackModel model)
        {
            var entity = await _context.Tracks.FindAsync(model.Id);
            if (entity == null) return null;
            // Validate foreign keys before updating
            if (!string.IsNullOrWhiteSpace(model.ProgramId))
            {
                var programExists = await _context.Programs.AnyAsync(p => p.ProgramId == model.ProgramId);
                if (!programExists)
                    throw new ArgumentException($"Program with ID {model.ProgramId} does not exist.");
            }

            if (!string.IsNullOrWhiteSpace(model.TeacherId))
            {
                var teacherExists = await _context.Teachers.AnyAsync(t => t.UserId == model.TeacherId);
                if (!teacherExists)
                    throw new ArgumentException($"Teacher with ID {model.TeacherId} does not exist.");
            }

            entity.Name = model.Name;
            entity.TeacherId = model.TeacherId;
            entity.ProgramId = model.ProgramId;

            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var entity = await _context.Tracks.FindAsync(id);
            if (entity == null) return false;

            entity.IsDeleted = true;
            entity.DeletedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(string id)
        {
            return await _context.Tracks.AnyAsync(t => t.TrackId == id);
        }

        public async Task<List<TrackModel>> GetDeletedAsync()
        {
            return await _context.Tracks
            .Where(t => t.IsDeleted)
            .Select(t => new TrackModel
            {
                Id = t.TrackId,
                Name = t.Name,
                TeacherId = t.TeacherId,
                ProgramId = t.ProgramId,
                IsDeleted = t.IsDeleted,
                DeletedAt = t.DeletedAt
            })
            .ToListAsync();
        }
    }
}