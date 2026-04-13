using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class AvailabilityModel : BaseModel
{
    public string Id { get; set; } = string.Empty;
    public string WeekDayId { get; set; } = string.Empty;
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string TeacherId { get; set; } = string.Empty;
    public string? AvailabilityGroupId { get; set; }
}
