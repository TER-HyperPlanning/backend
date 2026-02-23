namespace HP2.Application.DTOs.Auth;

/// <summary>
/// DTO pour récupérer les infos de l'utilisateur connecté
/// </summary>
public class CurrentUserResponse
{
    public string Id { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string Role { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
