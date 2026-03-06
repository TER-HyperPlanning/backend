namespace HP2.Application.DTOs.Teacher;

public class UpdateTeacherRequest
{
    public string Email { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public string Matricule { get; set; } = string.Empty;
    public string? TitleId { get; set; }
}