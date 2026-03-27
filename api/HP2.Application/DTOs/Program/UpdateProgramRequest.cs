using System.ComponentModel.DataAnnotations;

namespace HP2.Application.DTOs.Program;

public class UpdateProgramRequest
{
    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Field is required")]
    public string? Field { get; set; }
}
