using AutoMapper;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HP2.Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly TerHyperplanningContext _context;
        private readonly IMapper _mapper;

        public CourseRepository(TerHyperplanningContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CourseModel>> GetAllAsync()
        {
            var courses = await _context.Courses.Where(c => !c.IsDeleted).ToListAsync();
            return _mapper.Map<IEnumerable<CourseModel>>(courses);
        }

        public async Task<CourseModel?> GetByIdAsync(string id)
        {
            var course = await _context.Courses.FindAsync(id);
            return course == null ? null : _mapper.Map<CourseModel>(course);
        }

        public async Task<CourseModel> AddAsync(CourseModel model)
        {
            var entity = _mapper.Map<Course>(model);
            entity.CourseId = Guid.NewGuid().ToString();
            await _context.Courses.AddAsync(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<CourseModel>(entity);
        }

        public async Task<CourseModel?> UpdateAsync(CourseModel model)
        {
            var entity = await _context.Courses.FindAsync(model.Id);
            if (entity == null) return null;

            _mapper.Map(model, entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<CourseModel>(entity);
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null) return false;

            var sessions = await _context.Sessions.Where(s => s.CourseId == id && !s.IsDeleted).ToListAsync();
            foreach (var session in sessions)
            {
                session.IsDeleted = true;
                session.DeletedAt = DateTime.UtcNow;
            }

            course.IsDeleted = true;
            course.DeletedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<CourseModel>> GetDeletedAsync()
        {
            return await _context.Courses
                .Where(c => c.IsDeleted)
                .Select(c => new CourseModel
                {
                    Id = c.CourseId,
                    Name = c.Name,
                    Code = c.Code,
                    IsDeleted = c.IsDeleted,
                    DeletedAt = c.DeletedAt
                })
                .ToListAsync();
        }

        public async Task<bool> ExistsAsync(string id)
        {
            return await _context.Courses.AnyAsync(c => c.CourseId == id);
        }
    }
}