using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IUserRepository : IAsyncRepository<UserModel>
{
    Task<UserModel> CreateUserAsync(UserModel user);
    Task<UserModel?> GetUserByIdAsync(string id);
    Task<UserModel?> GetUserByEmailAsync(string email);
}
