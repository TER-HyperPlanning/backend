using System.ComponentModel.DataAnnotations;

namespace HP2.Application.DTOs.Admin;

public class UpdateAdminRequest
{
    [Required(ErrorMessage = "Email is required.")]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "First name is required.")]
    public string? FirstName { get; set; }

    [Required(ErrorMessage = "Last name is required.")]
    public string? LastName { get; set; }
    [Required(ErrorMessage = "Phone number is required.")]
    [RegularExpression(@"^\d{10,15}$", ErrorMessage = "Invalid phone number.")]
    public string? Phone { get; set; }
}