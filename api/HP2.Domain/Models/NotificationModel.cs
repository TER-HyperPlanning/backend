using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class NotificationModel : BaseModel
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
