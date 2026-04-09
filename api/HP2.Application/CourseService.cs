using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HP2.Application
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;

        public CourseService(ICourseRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<CourseModel>> GetAllAsync() => _repository.GetAllAsync();
        public Task<CourseModel?> GetByIdAsync(string id) => _repository.GetByIdAsync(id);
        public Task<CourseModel> AddAsync(CourseModel model) => _repository.AddAsync(model);
        public Task<CourseModel?> UpdateAsync(CourseModel model) => _repository.UpdateAsync(model);
        public Task<bool> DeleteAsync(string id) => _repository.DeleteAsync(id);
        public Task<List<CourseModel>> GetDeletedAsync() => _repository.GetDeletedAsync();
    }
}