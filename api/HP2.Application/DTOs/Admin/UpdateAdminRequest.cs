using System.ComponentModel.DataAnnotations;
namespace HP2.Application.DTOs.Admin;

public class UpdateAdminRequest
{
    [Required(ErrorMessage = "Email is required.")]
    public string Email { get; set; } = string.Empty;
    [Required(ErrorMessage = "First name is required.")]
    public string FirstName { get; set; } = string.Empty;
    [Required(ErrorMessage = "Last name is required.")]
    public string LastName { get; set; } = string.Empty;
    public string? Phone { get; set; }
}