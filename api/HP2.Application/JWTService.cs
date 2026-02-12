using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using HP2.Application.Contracts;
using Microsoft.IdentityModel.Tokens;

namespace HP2.Application;

public class JWTService : IJWTService
{
    private readonly string _issuer;
    private readonly string _audience;
    private readonly string _secretKey;
    private readonly int _expirationMinutes;

    public JWTService(string issuer, string audience, string secretKey, int expirationMinutes = 60)
    {
        _issuer = issuer;
        _audience = audience;
        _secretKey = secretKey;
        _expirationMinutes = expirationMinutes;
    }

    public string GenerateToken(string userId, string email, string firstName, string lastName, string role)
    {

        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, userId),
            new Claim(ClaimTypes.Email, email),
            new Claim(ClaimTypes.GivenName, firstName ?? string.Empty),
            new Claim(ClaimTypes.Surname, lastName ?? string.Empty),
            new Claim(ClaimTypes.Role, role)
        };

        var token = new JwtSecurityToken(
            issuer: _issuer,
            audience: _audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(_expirationMinutes),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public int GetTokenExpirationSeconds()
    {
        return _expirationMinutes * 60;
    }
}
