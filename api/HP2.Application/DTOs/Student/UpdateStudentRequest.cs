using System.ComponentModel.DataAnnotations;

namespace HP2.Application.DTOs.Student;

public class UpdateStudentRequest
{
    [Required] public string Email { get; set; } = string.Empty;
    [Required] public string FirstName { get; set; } = string.Empty;
    [Required] public string LastName { get; set; } = string.Empty;
    public string? Phone { get; set; }
    [Required] public string GroupId { get; set; } = string.Empty;
}
