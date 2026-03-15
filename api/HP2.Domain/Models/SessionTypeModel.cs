using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class SessionTypeModel : BaseModel
{
    public string Id { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
}
