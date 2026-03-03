using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IAvailabilityRepository : IAsyncRepository<AvailabilityModel>
{
    Task<IReadOnlyList<AvailabilityModel>> GetByTeacherAsync(string teacherId);

    Task<bool> HasConflictAsync(
        string teacherId,
        string weekDayId,
        TimeSpan startTime,
        TimeSpan endTime,
        DateTime startDate,
        DateTime endDate,
        string? excludeId = null);
}