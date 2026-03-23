namespace HP2.Application.DTOs.Assign;

public class UpdateAssignRequest
{
    public string TrackId { get; set; } = string.Empty;
    public string CourseId { get; set; } = string.Empty;
    public int HourlyVolume { get; set; }
}