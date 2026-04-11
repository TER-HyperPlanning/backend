using HP2.Application.DTOs.Availability;
using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IAvailabilityGroupRepository : IAsyncRepository<AvailabilityGroupModel>
{
    Task<AvailabilityGroupResponse?> GetResponseByIdAsync(string id);
    Task<IReadOnlyList<AvailabilityGroupResponse>> GetByTeacherAsync(string teacherId);
}
