using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class ReceiveModel : BaseModel
{
    public string? TeacherId { get; set; }
    public string? StudentId { get; set; }
    public string? AdminId { get; set; }
    public string NotificationId { get; set; } = string.Empty;
}
