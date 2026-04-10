using HP2.Application.Contracts;
using HP2.Application.Exceptions;
using HP2.Domain.Models;
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

        public async Task<IEnumerable<CourseModel>> GetAllAsync() => await _repository.GetAllAsync();
        public Task<CourseModel?> GetByIdAsync(string id) => _repository.GetByIdAsync(id);
        public async Task<IEnumerable<CourseModel>> GetDeletedAsync() => await _repository.GetDeletedAsync();
        public Task<CourseModel> AddAsync(CourseModel model) => _repository.AddAsync(model);

        public Task UpdateAsync(CourseModel model) => _repository.UpdateAsync(model);

        public async Task DeleteAsync(string id)
        {
            var blockingSession = await _repository.GetFirstNotYetPassedSessionUsingCourseAsync(id, DateTime.UtcNow);
            if (blockingSession != null)
            {
                throw new DeleteConflictException(
                    $"Cannot delete course '{id}' because session '{blockingSession.SessionId}' has not ended yet.",
                    blockingSession);
            }

            await _repository.DeleteAsync(id);
        }
    }
}