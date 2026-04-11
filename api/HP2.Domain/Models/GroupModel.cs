using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class GroupModel : BaseModel
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string AcademicYear { get; set; } = string.Empty;
    public int Place { get; set; }
    public string TrackId { get; set; } = string.Empty;
}
