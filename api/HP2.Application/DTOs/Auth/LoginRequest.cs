namespace HP2.Application.DTOs.Auth;

/// <summary>
/// DTO pour la requête de connexion
/// </summary>
public class LoginRequest
{
    /// <summary>
    /// Email de l'utilisateur
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Mot de passe en clair
    /// </summary>
    public string Password { get; set; } = string.Empty;
}
