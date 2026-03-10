using HP2.Application.DTOs.Auth;

namespace HP2.Application.Contracts;

public interface IAuthenticationService
{
    Task<LoginResponse> Login(LoginRequest request);
    Task<CurrentUserResponse> GetCurrentUser(string userId);
}
