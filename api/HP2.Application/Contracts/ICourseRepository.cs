using HP2.Domain.Models;
using HP2.Application.DTOs.Session;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HP2.Application.Contracts
{
    public interface ICourseRepository : IAsyncRepository<CourseModel>
    {
        Task<IReadOnlyList<CourseModel>> GetDeletedAsync();
        Task<BlockingSessionInfo?> GetFirstNotYetPassedSessionUsingCourseAsync(string courseId, DateTime referenceDateTime);
    }
}