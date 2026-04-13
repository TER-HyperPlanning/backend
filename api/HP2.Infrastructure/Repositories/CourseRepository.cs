using AutoMapper;
using HP2.Application.Contracts;
using HP2.Application.DTOs.Session;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HP2.Infrastructure.Repositories
{
    public class CourseRepository : RepositoryBase<CourseModel>, ICourseRepository
    {
        public CourseRepository(TerHyperplanningContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<IReadOnlyList<CourseModel>> GetAllFilteredAsync(string? name, string? code)
        {
            var query = _dbContext.Courses
            .AsNoTracking()
            .AsQueryable();
            
            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(c => c.Name.Contains(name));
            }
            
            if (!string.IsNullOrWhiteSpace(code))
            {
                query = query.Where(c => c.Code.Contains(code));
            }
            
            var courses = await query.ToListAsync();
            
            return _mapper.Map<List<CourseModel>>(courses);
        }

        public async Task<IReadOnlyList<CourseModel>> GetDeletedAsync()
        {
            var courses = await _dbContext.Courses
                .IgnoreQueryFilters()
                .AsNoTracking()
                .Where(c => c.IsDeleted)
                .ToListAsync();

            return _mapper.Map<List<CourseModel>>(courses);
        }

        public override async Task<CourseModel?> GetByIdAsync(string id)
        {
            var course = await _dbContext.Courses
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CourseId == id);

            return course == null ? null : _mapper.Map<CourseModel>(course);
        }

        public override async Task<CourseModel> AddAsync(CourseModel model)
        {
            var entity = _mapper.Map<Course>(model);
            entity.CourseId = Guid.NewGuid().ToString();
            entity.IsDeleted = false;
            entity.DeletedAt = null;

            await _dbContext.Courses.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            model.Id = entity.CourseId;
            model.IsDeleted = entity.IsDeleted;
            model.DeletedAt = entity.DeletedAt;
            return model;
        }

        public override async Task UpdateAsync(CourseModel model)
        {
            var entity = await _dbContext.Courses
                .FirstOrDefaultAsync(c => c.CourseId == model.Id);
            if (entity == null)
            {
                return;
            }

            entity.Name = model.Name;
            entity.Code = model.Code;
            entity.IsDeleted = model.IsDeleted;
            entity.DeletedAt = model.DeletedAt;

            await _dbContext.SaveChangesAsync();
        }

        public override async Task DeleteAsync(string id)
        {
            await base.DeleteAsync(id);
        }

        public Task<BlockingSessionInfo?> GetFirstNotYetPassedSessionUsingCourseAsync(string courseId, DateTime referenceDateTime)
        {
            var referenceDate = referenceDateTime.Date;
            var referenceTime = referenceDateTime.TimeOfDay;

            return _dbContext.Sessions
                .AsNoTracking()
                .Where(s => s.CourseId == courseId
                            && (s.Date > referenceDate
                                || (s.Date == referenceDate && s.EndTime > referenceTime)))
                .OrderBy(s => s.Date)
                .ThenBy(s => s.StartTime)
                .Select(s => new BlockingSessionInfo
                {
                    SessionId = s.SessionId,
                    StartDateTime = s.Date.Date + s.StartTime,
                    EndDateTime = s.Date.Date + s.EndTime,
                    RoomId = s.RoomId,
                    RoomNumber = s.Room.RoomNumber,
                    CourseId = s.CourseId,
                    CourseName = s.Course.Name
                })
                .FirstOrDefaultAsync();
        }
    }
}