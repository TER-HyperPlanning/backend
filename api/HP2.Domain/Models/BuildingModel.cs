using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class BuildingModel : BaseModel
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}
