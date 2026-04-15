using System.ComponentModel.DataAnnotations;
using HP2.Domain.Enums;

namespace HP2.Application.DTOs.Unavailableday;

public class CreateUnavailabledayRequest
{
    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }

    [Required]
    public string StartTime { get; set; } = null!;

    [Required]
    public string EndTime { get; set; } = null!;

    // public string UnavailableDayTypeId { get; set; } = string.Empty;
    // use the enums
    [Required]
    public UnavailableDayTypeEnum Type { get; set; }
}