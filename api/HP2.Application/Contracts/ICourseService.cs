using HP2.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HP2.Application.Contracts
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseModel>> GetAllAsync();
        Task<IEnumerable<CourseModel>> GetDeletedAsync();
        Task<CourseModel?> GetByIdAsync(string id);
        Task<CourseModel> AddAsync(CourseModel model);
        Task UpdateAsync(CourseModel model);
        Task DeleteAsync(string id);
    }
}