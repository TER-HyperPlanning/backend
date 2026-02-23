namespace HP2.Application.Contracts;

public interface IJWTService
{
    string GenerateToken(string userId, string email, string firstName, string lastName, string role);
    int GetTokenExpirationSeconds();
}
