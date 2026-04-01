using System.ComponentModel.DataAnnotations;

namespace HP2.Application.DTOs.Course;

public class UpdateCourseRequest
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Code is required")]
    public string Code { get; set; } = string.Empty;
}