using System.ComponentModel.DataAnnotations;

namespace HP2.Application.DTOs.Availability;

public class UpdateAvailabilityRequest
{
    [Required]
    public string WeekDayId { get; set; } = string.Empty;

    [Required]
    public TimeSpan StartTime { get; set; }

    [Required]
    public TimeSpan EndTime { get; set; }

    [Required]
    public DateTime? StartDate { get; set; }

    [Required]
    public DateTime? EndDate { get; set; }

    [Required]
    public string TeacherId { get; set; } = string.Empty;

    public string? AvailabilityGroupId { get; set; }
}