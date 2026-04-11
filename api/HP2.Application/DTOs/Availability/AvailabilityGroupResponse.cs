namespace HP2.Application.DTOs.Availability;

public class AvailabilityGroupResponse
{
    public string Id { get; set; } = string.Empty;
    public string TeacherId { get; set; } = string.Empty;
    public int NumberOfAvailableDays { get; set; }
}
