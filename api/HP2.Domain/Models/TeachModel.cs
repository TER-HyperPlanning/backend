using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class TeachModel : SoftDeletableModel
{
    public string SessionId { get; set; } = string.Empty;
    public string TeacherId { get; set; } = string.Empty;
}
