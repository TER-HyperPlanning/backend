using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class AvailabilityGroupModel : BaseModel
{
    public string Id { get; set; } = string.Empty;
    public string TeacherId { get; set; } = string.Empty;
    public int NumberOfAvailableDays { get; set; }
}
