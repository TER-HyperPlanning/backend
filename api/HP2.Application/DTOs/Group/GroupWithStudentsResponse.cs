using HP2.Application.DTOs.Student;

namespace HP2.Application.DTOs.Group;

public class GroupWithStudentsResponse
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string AcademicYear { get; set; } = string.Empty;
    public string? TrackId { get; set; }
    public int StudentCount { get; set; }
    public IEnumerable<StudentResponse> Students { get; set; } = new List<StudentResponse>();
}
