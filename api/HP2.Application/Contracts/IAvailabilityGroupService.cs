using HP2.Application.DTOs.Availability;
using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IAvailabilityGroupService
{
    Task<AvailabilityGroupResponse> CreateAsync(AvailabilityGroupModel model);
    Task<AvailabilityGroupResponse> UpdateAsync(string id, AvailabilityGroupModel model);
    Task DeleteAsync(string id);
    Task<IReadOnlyList<AvailabilityGroupResponse>> GetByTeacherAsync(string teacherId);
    Task<AvailabilityGroupResponse?> GetByIdAsync(string id);
}
