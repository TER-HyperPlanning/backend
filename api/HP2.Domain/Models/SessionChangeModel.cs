using HP2.Domain.Common;
using HP2.Domain.Enums;

namespace HP2.Domain.Models;

public class SessionChangeModel : BaseModel
{
    public string Id { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Reason { get; set; } = string.Empty;

    public string TeacherId { get; set; } = string.Empty;
    public string SessionId { get; set; } = string.Empty;
    public string ChangeStatusId { get; set; } = string.Empty;

    public SessionChangeType ChangeType { get; set; }

    public string? ApprovedRoomId { get; set; }

    public DateTime? ProposedDate { get; set; }
    public TimeSpan? ProposedStartTime { get; set; }
    public TimeSpan? ProposedEndTime { get; set; }
    public string? ProposedRoomId { get; set; }

    public DateTime? CounterProposalDate { get; set; }
    public TimeSpan? CounterProposalStartTime { get; set; }
    public TimeSpan? CounterProposalEndTime { get; set; }
    public string? CounterProposalRoomId { get; set; }

    public string? RejectionReason { get; set; }

    // ===== Champs de lecture enrichis pour le front =====
    public string? TeacherName { get; set; }
    public string? TeacherEmail { get; set; }

    public string? CourseName { get; set; }

    public DateTime? SessionDate { get; set; }
    public TimeSpan? SessionStartTime { get; set; }
    public TimeSpan? SessionEndTime { get; set; }

    public string? CurrentRoomId { get; set; }
    public string? CurrentRoomNumber { get; set; }
    public string? CurrentBuildingName { get; set; }

    public string? ApprovedRoomNumber { get; set; }
    public string? ApprovedBuildingName { get; set; }

    public string? ProposedRoomNumber { get; set; }
    public string? ProposedBuildingName { get; set; }

    public string? CounterProposalRoomNumber { get; set; }
    public string? CounterProposalBuildingName { get; set; }

    public string? ChangeStatusLabel { get; set; }
}