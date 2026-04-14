using AutoMapper;
using HP2.Application.Contracts;
using HP2.Application.DTOs.Assign;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace HP2.Infrastructure.Repositories
{
    public class TrackRepository : RepositoryBase<TrackModel>, ITrackRepository
    {
        public TrackRepository(TerHyperplanningContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public override async Task<IReadOnlyList<TrackModel>> GetAllAsync()
        {
            return await _dbContext.Tracks
                .Select(t => new TrackModel
                {
                    Id = t.TrackId,
                    Name = t.Name,
                    TeacherId = t.TeacherId,
                    ProgramId = t.ProgramId,
                    Description = t.Description,
                    Lieu = t.Lieu,
                    IsDeleted = t.IsDeleted,
                    DeletedAt = t.DeletedAt
                })
                .ToListAsync();
        }

        async Task<List<TrackModel>> ITrackRepository.GetAllAsync(string? programId, string? name)
        {
            var query = _dbContext.Tracks.AsQueryable();
            if (!string.IsNullOrWhiteSpace(programId))
            {
                query = query.Where(t => t.ProgramId == programId);
            }
            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(t => t.Name.Contains(name));
            }
            return (await query
            .Select(t => new TrackModel
            {
                Id = t.TrackId,
                Name = t.Name,
                TeacherId = t.TeacherId,
                ProgramId = t.ProgramId,
                Description = t.Description,
                Lieu = t.Lieu,
                IsDeleted = t.IsDeleted,
                DeletedAt = t.DeletedAt
            })
            .ToListAsync());
        }

        public override async Task<TrackModel?> GetByIdAsync(string id)
        {
            var t = await _dbContext.Tracks.FirstOrDefaultAsync(x => x.TrackId == id);
            if (t == null) return null;

            return new TrackModel
            {
                Id = t.TrackId,
                Name = t.Name,
                TeacherId = t.TeacherId,
                ProgramId = t.ProgramId,
                Description = t.Description,
                Lieu = t.Lieu,
                IsDeleted = t.IsDeleted,
                DeletedAt = t.DeletedAt
            };
        }

        async Task<TrackModel?> ITrackRepository.GetByIdAsync(string id)
        {
            return await GetByIdAsync(id);
        }

        public override async Task<TrackModel> AddAsync(TrackModel model)
        {
            if (!string.IsNullOrWhiteSpace(model.ProgramId))
            {
                var programExists = await _dbContext.Programs.AnyAsync(p => p.ProgramId == model.ProgramId);
                if (!programExists)
                    throw new ArgumentException($"Program with ID {model.ProgramId} does not exist.");
            }

            if (!string.IsNullOrWhiteSpace(model.TeacherId))
            {
                var teacherExists = await _dbContext.Teachers.AnyAsync(t => t.UserId == model.TeacherId);
                if (!teacherExists)
                    throw new ArgumentException($"Teacher with ID {model.TeacherId} does not exist.");
            }

            var entity = new Track
            {
                TrackId = model.Id ?? Guid.NewGuid().ToString(),
                Name = model.Name,
                TeacherId = model.TeacherId,
                ProgramId = model.ProgramId,
                Description = model.Description,
                Lieu = model.Lieu,
                IsDeleted = false,
                DeletedAt = null
            };

            _dbContext.Tracks.Add(entity);
            await _dbContext.SaveChangesAsync();

            model.Id = entity.TrackId;
            model.IsDeleted = entity.IsDeleted;
            model.DeletedAt = entity.DeletedAt;
            return model;
        }

        public override async Task UpdateAsync(TrackModel model)
        {
            var entity = await _dbContext.Tracks.FindAsync(model.Id);
            if (entity == null) return;

            if (!string.IsNullOrWhiteSpace(model.ProgramId))
            {
                var programExists = await _dbContext.Programs.AnyAsync(p => p.ProgramId == model.ProgramId);
                if (!programExists)
                    throw new ArgumentException($"Program with ID {model.ProgramId} does not exist.");
            }

            if (!string.IsNullOrWhiteSpace(model.TeacherId))
            {
                var teacherExists = await _dbContext.Teachers.AnyAsync(t => t.UserId == model.TeacherId);
                if (!teacherExists)
                    throw new ArgumentException($"Teacher with ID {model.TeacherId} does not exist.");
            }

            entity.Name = model.Name;
            entity.TeacherId = model.TeacherId;
            entity.ProgramId = model.ProgramId;
            entity.Description = model.Description;
            entity.Lieu = model.Lieu;
            entity.IsDeleted = model.IsDeleted;
            entity.DeletedAt = model.DeletedAt;

            await _dbContext.SaveChangesAsync();
        }

        async Task<TrackModel> ITrackRepository.UpdateAsync(TrackModel model)
        {
            await UpdateAsync(model);
            return model;
        }

        public override async Task DeleteAsync(string id)
        {
            var assigns = await _dbContext.Assigns
                .Where(a => a.TrackId == id && !a.IsDeleted)
                .ToListAsync();

            if (assigns.Count > 0)
            {
                var deletedAt = DateTime.UtcNow;
                foreach (var assign in assigns)
                {
                    assign.IsDeleted = true;
                    assign.DeletedAt = deletedAt;
                }

                await _dbContext.SaveChangesAsync();
            }

            await base.DeleteAsync(id);
        }

        async Task<bool> ITrackRepository.DeleteAsync(string id)
        {
            var exists = await ExistsAsync(id);
            if (!exists)
            {
                return false;
            }

            await DeleteAsync(id);
            return true;
        }

        public async Task<bool> ExistsAsync(string id)
        {
            return await _dbContext.Tracks.AnyAsync(t => t.TrackId == id);
        }

        public async Task<List<TrackModel>> GetDeletedAsync()
        {
            return await _dbContext.Tracks
                .IgnoreQueryFilters()
                .Where(t => t.IsDeleted)
                .Select(t => new TrackModel
                {
                    Id = t.TrackId,
                    Name = t.Name,
                    TeacherId = t.TeacherId,
                    ProgramId = t.ProgramId,
                    Description = t.Description,
                    Lieu = t.Lieu,
                    IsDeleted = t.IsDeleted,
                    DeletedAt = t.DeletedAt
                })
                .ToListAsync();
        }

        public async Task<AssignResponse?> GetFirstAssignByTrackIdAsync(string trackId)
        {
            return await _dbContext.Assigns
                .AsNoTracking()
                .Where(a => a.TrackId == trackId)
                .OrderBy(a => a.CourseId)
                .Select(a => new AssignResponse
                {
                    TrackId = a.TrackId,
                    CourseId = a.CourseId,
                    HourlyVolume = a.HourlyVolume
                })
                .FirstOrDefaultAsync();
        }
    }
}