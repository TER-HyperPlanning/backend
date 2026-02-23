using AutoMapper;
using HP2.Application.Contracts;
using HP2.Infrastructure.Persistence;
using HP2.Domain.Models;
using Microsoft.EntityFrameworkCore;
using HP2.Infrastructure.Persistence.Entities;

namespace HP2.Infrastructure.Repositories;

public class UserRepository : RepositoryBase<UserModel>, IUserRepository
{
    public UserRepository(TerHyperplanningContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }

    public async Task<UserModel> CreateUserAsync(UserModel user)
    {
        var entity = _mapper.Map<User>(user);
        entity.CreatedAt = DateTime.UtcNow;
        entity.UpdatedAt = DateTime.UtcNow;
        _dbContext.Users.Add(entity);
        await _dbContext.SaveChangesAsync();
        return _mapper.Map<UserModel>(entity);
    }

    public async Task<UserModel?> GetUserByIdAsync(string id)
    {
        var user = await _dbContext.Users.FindAsync(id);
        return user != null ? _mapper.Map<UserModel>(user) : null;
    }

    public async Task<UserModel?> GetUserByEmailAsync(string email)
    {
        var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        return user != null ? _mapper.Map<UserModel>(user) : null;
    }
}
