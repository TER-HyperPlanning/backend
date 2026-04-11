using System.Text.Json.Serialization;
using HP2.Domain.Enums;

namespace HP2.Application.DTOs.Student;

public class StudentResponse
{
    public string Id { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public string? GroupId { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public UserRole Role { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}
