namespace HP2.Application.DTOs.Availability;

public class AvailabilityResponse
{
    public string Id { get; set; } = string.Empty;
    public string WeekDay { get; set; } = string.Empty;
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string TeacherId { get; set; } = string.Empty;
}