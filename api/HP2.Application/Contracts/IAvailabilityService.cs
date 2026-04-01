using HP2.Application.DTOs.Availability;
using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IAvailabilityService
{
    Task<AvailabilityResponse> CreateAsync(AvailabilityModel model);
    Task<AvailabilityResponse> UpdateAsync(string id, AvailabilityModel model);
    Task DeleteAsync(string id);
    Task<IReadOnlyList<AvailabilityResponse>> GetByTeacherAsync(string teacherId);
}