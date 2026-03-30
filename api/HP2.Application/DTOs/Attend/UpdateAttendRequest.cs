namespace HP2.Application.DTOs.Attend;

public class UpdateAttendRequest
{
    public string CurrentGroupId { get; set; } = string.Empty;
    public string CurrentSessionId { get; set; } = string.Empty;
    public string GroupId { get; set; } = string.Empty;
    public string SessionId { get; set; } = string.Empty;
}
