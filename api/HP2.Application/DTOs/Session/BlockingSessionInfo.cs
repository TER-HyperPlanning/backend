namespace HP2.Application.DTOs.Session;

public class BlockingSessionInfo
{
    public string SessionId { get; set; } = string.Empty;
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public string RoomId { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
    public string CourseId { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;
}