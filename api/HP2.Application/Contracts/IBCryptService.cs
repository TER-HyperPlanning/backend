namespace HP2.Application.Contracts;

public interface IBCryptService
{
    string HashPassword(string password);
    bool VerifyPassword(string password, string hashedPassword);
}
