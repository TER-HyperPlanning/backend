// api/HP2.Domain/Models/SessionRoomChangeModel.cs
using HP2.Domain.Common;

namespace HP2.Domain.Models;

public class SessionRoomChangeModel : BaseModel
{
    public string Id { get; set; } = string.Empty;

    public DateTime Date { get; set; }

    public string Reason { get; set; } = string.Empty;

    public string TeacherId { get; set; } = string.Empty;

    public string SessionId { get; set; } = string.Empty;

    public string ChangeStatusId { get; set; } = string.Empty;

    public string? ApprovedRoomId { get; set; }

    public string? RejectionReason { get; set; }
}