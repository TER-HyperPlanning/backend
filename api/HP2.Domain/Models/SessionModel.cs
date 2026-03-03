using HP2.Domain.Common;
using HP2.Domain.Enums;
namespace HP2.Domain.Models;

public class SessionModel : BaseModel
{
    public string Id { get; set; } = string.Empty;

    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }

    public SessionMode Mode { get; set; }
    public string SessionTypeId { get; set; } = string.Empty;
    public string CourseId { get; set; } = string.Empty;
    public string SessionStatusId { get; set; } = string.Empty;
    public string RoomId { get; set; } = string.Empty;

    public string? Description { get; set; }

    // ajout pour lecture
    public string? SessionTypeLabel { get; set; }
    public string? SessionStatusLabel { get; set; }
    public string? RoomNumber { get; set; }
}