using System.ComponentModel.DataAnnotations;
using HP2.Domain.Enums;

namespace HP2.Application.DTOs.Teacher;

public class CreateTeacherRequest
{
    [Required] public string Email { get; set; } = string.Empty;
    [Required] public string Password { get; set; } = string.Empty;
    [Required] public string FirstName { get; set; } = string.Empty;
    [Required] public string LastName { get; set; } = string.Empty;
    [Required] public string? Phone { get; set; }
    [Required] public string Matricule { get; set; } = string.Empty;
    [Required] public TeacherTitle? Title { get; set; }
}