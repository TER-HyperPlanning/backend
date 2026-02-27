using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IAvailabilityService
{
    Task<AvailabilityModel> CreateAsync(AvailabilityModel model);
    Task UpdateAsync(string id, AvailabilityModel model);
    Task DeleteAsync(string id);
    Task<IReadOnlyList<AvailabilityModel>> GetByTeacherAsync(string teacherId);
}