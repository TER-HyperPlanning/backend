using HP2.Domain.Common;
using HP2.Domain.Enums;

namespace HP2.Domain.Models;

public class UnavailableDayModel : BaseModel
{
    public string Id { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    // public string UnavailableDayTypeId { get; set; } = string.Empty;
    public UnavailableDayTypeEnum Type { get; set; }
}
