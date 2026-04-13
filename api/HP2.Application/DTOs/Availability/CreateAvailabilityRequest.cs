using System.ComponentModel.DataAnnotations;
using HP2.Domain.Enums;

namespace HP2.Application.DTOs.Availability;

public class CreateAvailabilityRequest
{
    [Required]
    [EnumDataType(typeof(WeekDay))]
    public WeekDay WeekDay { get; set; }

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