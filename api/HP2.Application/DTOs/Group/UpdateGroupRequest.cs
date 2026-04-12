namespace HP2.Application.DTOs.Group;

public class UpdateGroupRequest
{
    public string Name { get; set; } = string.Empty;
    public string AcademicYear { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public string TrackId { get; set; } = string.Empty;
}
