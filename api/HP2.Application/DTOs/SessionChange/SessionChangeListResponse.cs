namespace HP2.Application.DTOs.SessionChange;

public class SessionChangeListResponse
{
    public string Id { get; set; } = string.Empty;

    public string TeacherId { get; set; } = string.Empty;
    public string TeacherName { get; set; } = string.Empty;
    public string TeacherEmail { get; set; } = string.Empty;

    public string SessionId { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;

    public DateTime SessionDate { get; set; }
    public TimeSpan SessionStartTime { get; set; }
    public TimeSpan SessionEndTime { get; set; }

    public string CurrentRoomNumber { get; set; } = string.Empty;
    public string CurrentBuildingName { get; set; } = string.Empty;

    public string ChangeStatusId { get; set; } = string.Empty;
    public string ChangeStatusLabel { get; set; } = string.Empty;

    public string ChangeType { get; set; } = string.Empty;

    public string Reason { get; set; } = string.Empty;
    public DateTime RequestDate { get; set; }
}