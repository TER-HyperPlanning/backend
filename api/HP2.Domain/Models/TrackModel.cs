using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class TrackModel : BaseModel, ISoftDeletable
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string TeacherId { get; set; } = string.Empty;
    public string ProgramId { get; set; } = string.Empty;
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }
}
