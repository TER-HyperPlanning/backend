using HP2.Domain.Enums;

namespace HP2.Application.DTOs.Unavailableday;

public class CreateUnavailabledayRequest
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    // public string UnavailableDayTypeId { get; set; } = string.Empty;
    // use the enums
    public UnavailableDayTypeEnum Type { get; set; }
}