using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class AttendModel : BaseModel
{
    public string GroupId { get; set; } = string.Empty;
    public string SessionId { get; set; } = string.Empty;
}
