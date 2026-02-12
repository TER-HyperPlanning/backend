using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IAuthRepository
{
    Task<UserModel?> GetUserByEmailAsync(string email);
    Task<UserModel?> GetUserByIdAsync(string id);
    Task<UserModel> CreateUserAsync(UserModel user);
}
