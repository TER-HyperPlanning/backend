namespace HP2.Application.DTOs.Teacher;

public class CreateTeacherRequest
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public string Matricule { get; set; } = string.Empty;
    public string? TitleId { get; set; }
}