using AutoMapper;
using HP2.Application.Contracts;
using HP2.Infrastructure.Persistence;
using HP2.Domain.Models;
using Microsoft.EntityFrameworkCore;
using HP2.Infrastructure.Persistence.Entities;

namespace HP2.Infrastructure.Repositories;

public class AuthRepository : IAuthRepository
{
    private readonly TerHyperplanningContext _dbContext;
    private readonly IMapper _mapper;

    public AuthRepository(TerHyperplanningContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<UserModel?> GetUserByEmailAsync(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return null;
        }

        var user = await _dbContext.Users
            .Include(u => u.UserRole)
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Email == email);

        return user != null ? _mapper.Map<UserModel>(user) : null;
    }

    public async Task<UserModel?> GetUserByIdAsync(string id)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            return null;
        }

        var user = await _dbContext.Users
            .Include(u => u.UserRole)
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.UserId == id);

        return user != null ? _mapper.Map<UserModel>(user) : null;
    }

    public async Task<UserModel> CreateUserAsync(UserModel userModel)
    {
        var entity = _mapper.Map<User>(userModel);
        entity.CreatedAt = DateTime.UtcNow;

        _dbContext.Users.Add(entity);
        await _dbContext.SaveChangesAsync();

        return _mapper.Map<UserModel>(entity);
    }
}
