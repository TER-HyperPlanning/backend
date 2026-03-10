using HP2.Application.Contracts;
using HP2.Application.DTOs.Auth;
using HP2.Application.Security;
using HP2.Domain.Enums;

namespace HP2.Application;

public class AuthenticationService : IAuthenticationService
{
    private readonly IAuthRepository _authRepository;
    private readonly IBCryptService _bcryptService;
    private readonly IJWTService _jwtService;

    public AuthenticationService(
        IAuthRepository authRepository,
        IBCryptService bcryptService,
        IJWTService jwtService)
    {
        _authRepository = authRepository ?? throw new ArgumentNullException(nameof(authRepository));
        _bcryptService = bcryptService ?? throw new ArgumentNullException(nameof(bcryptService));
        _jwtService = jwtService ?? throw new ArgumentNullException(nameof(jwtService));
    }

    public async Task<LoginResponse> Login(LoginRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Email) || string.IsNullOrWhiteSpace(request.Password))
        {
            throw new UnauthorizedAccessException("Email et mot de passe sont requis.");
        }

        // Récupérer l'utilisateur par email
        var user = await _authRepository.GetUserByEmailAsync(request.Email);
        
        if (user == null)
        {
            throw new UnauthorizedAccessException("Email ou mot de passe invalide.");
        }

        // Vérifier le mot de passe
        if (!_bcryptService.VerifyPassword(request.Password, user.Password))
        {
            throw new UnauthorizedAccessException("Email ou mot de passe invalide.");
        }

        // Générer le token JWT
        var token = _jwtService.GenerateToken(
            user.Id,
            user.Email,
            user.FirstName,
            user.LastName,
            user.Role.ToString()
        );

        return new LoginResponse
        {
            AccessToken = token,
            ExpiresIn = _jwtService.GetTokenExpirationSeconds()
        };
    }

    public async Task<CurrentUserResponse> GetCurrentUser(string userId)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentNullException(nameof(userId));
        }

        var user = await _authRepository.GetUserByIdAsync(userId);

        if (user == null)
        {
            throw new KeyNotFoundException($"Utilisateur avec l'ID '{userId}' non trouvé.");
        }

        return new CurrentUserResponse
        {
            Id = user.Id,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            PhoneNumber = user.Phone,
            Role = user.Role.ToString(),
            CreatedAt = user.CreatedAt
        };
    }
}
