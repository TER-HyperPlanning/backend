using HP2.Domain.Enums;
namespace HP2.Application.DTOs.Availability;

public class AvailabilityResponse
{
    public string Id { get; set; } = string.Empty;
    public WeekDay WeekDay { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string TeacherId { get; set; } = string.Empty;
}