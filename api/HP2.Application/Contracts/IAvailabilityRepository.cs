using HP2.Application.DTOs.Availability;
using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IAvailabilityRepository : IAsyncRepository<AvailabilityModel>
{
    Task<IReadOnlyList<AvailabilityResponse>> GetByTeacherAsync(string teacherId);
    Task<AvailabilityResponse?> GetResponseByIdAsync(string id);

    Task<bool> HasConflictAsync(
        string teacherId,
        string weekDayId,
        TimeSpan startTime,
        TimeSpan endTime,
        DateTime startDate,
        DateTime endDate,
        string? excludeId = null);
}