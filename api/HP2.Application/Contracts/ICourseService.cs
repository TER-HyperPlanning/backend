using HP2.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HP2.Application.Contracts
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseModel>> GetAllAsync();
        Task<CourseModel?> GetByIdAsync(string id);
        Task<CourseModel> AddAsync(CourseModel model);
        Task<CourseModel?> UpdateAsync(CourseModel model);
        Task<bool> DeleteAsync(string id);
        Task<List<CourseModel>> GetDeletedAsync();
    }
}