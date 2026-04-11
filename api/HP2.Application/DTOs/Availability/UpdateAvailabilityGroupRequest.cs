using System.ComponentModel.DataAnnotations;

namespace HP2.Application.DTOs.Availability;

public class UpdateAvailabilityGroupRequest
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "NumberOfAvailableDays must be at least 1.")]
    public int NumberOfAvailableDays { get; set; }
}
