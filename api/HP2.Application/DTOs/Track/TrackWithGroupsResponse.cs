using HP2.Application.DTOs.Group;
using HP2.Application.DTOs.Student;

namespace HP2.Application.DTOs.Track;

public class TrackWithGroupsResponse
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string TeacherId { get; set; } = string.Empty;
    public string ProgramId { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Lieu { get; set; }
    public DateTime? DeletedAt { get; set; }
    public int StudentCount { get; set; }
    public IEnumerable<GroupWithStudentsResponse> Groups { get; set; } = new List<GroupWithStudentsResponse>();
    public IEnumerable<StudentResponse> Students { get; set; } = new List<StudentResponse>();
}
