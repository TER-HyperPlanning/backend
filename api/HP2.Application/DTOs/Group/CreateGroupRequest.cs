namespace HP2.Application.DTOs.Group;

public class CreateGroupRequest
{
    public string Name { get; set; } = string.Empty;
    public string AcademicYear { get; set; } = string.Empty;
    public int Place { get; set; }
    public string TrackId { get; set; } = string.Empty;
}
