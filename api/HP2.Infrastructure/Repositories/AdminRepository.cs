using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using DomainUserRole = HP2.Domain.Enums.UserRole;

namespace HP2.Infrastructure.Repositories;

public class AdminRepository : RepositoryBase<AdminModel>, IAdminRepository
{
    public AdminRepository(TerHyperplanningContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }

    public override async Task<IReadOnlyList<AdminModel>> GetAllAsync()
    {
        var admins = await _dbContext.Admins
        .Include(a => a.User)
        .ThenInclude(u => u.UserRole)
        .ToListAsync();

        return _mapper.Map<List<AdminModel>>(admins);
    }

    public override async Task<AdminModel?> GetByIdAsync(string id)
    {
        var admin = await _dbContext.Admins
            .Include(a => a.User)
            .ThenInclude(u => u.UserRole)
            .FirstOrDefaultAsync(a => a.UserId == id);

        return admin != null ? _mapper.Map<AdminModel>(admin) : null;
    }

    public async Task<AdminModel?> GetByEmailAsync(string email)
{
    var admin = await _dbContext.Admins
        .Include(a => a.User)
        .ThenInclude(u => u.UserRole)
        .FirstOrDefaultAsync(a => a.User != null && a.User.Email == email);

    return admin != null ? _mapper.Map<AdminModel>(admin) : null;
}

    public override async Task<AdminModel> AddAsync(AdminModel adminModel)
    {
        var adminRole = await _dbContext.UserRoles.FirstOrDefaultAsync(r => r.Name == "ADMIN");
        var user = new Infrastructure.Persistence.Entities.User
        {
            UserId = Guid.NewGuid().ToString(),
            Email = adminModel.Email,
            Password = adminModel.Password,
            FirstName = adminModel.FirstName,
            LastName = adminModel.LastName,
            PhoneNumber = adminModel.Phone,
            UserRoleId = adminRole?.UserRoleId ?? throw new Exception("Rôle ADMIN introuvable"),
            CreatedAt = DateTime.UtcNow
        };

        var admin = new Infrastructure.Persistence.Entities.Admin
        {
            UserId = user.UserId,
            User = user
        };

        await _dbContext.Users.AddAsync(user);
        await _dbContext.Admins.AddAsync(admin);

        await _dbContext.SaveChangesAsync();

        adminModel.Id = user.UserId;
        adminModel.Role = DomainUserRole.ADMIN;
        return adminModel;
    }

    public override async Task UpdateAsync(AdminModel adminModel)
    {
        var admin = await _dbContext.Admins
            .Include(a => a.User)
            .FirstOrDefaultAsync(a => a.UserId == adminModel.Id);

        if (admin == null) return;

        if (admin.User != null)
        {
            admin.User.Email = adminModel.Email;
            admin.User.FirstName = adminModel.FirstName;
            admin.User.LastName = adminModel.LastName;
            admin.User.PhoneNumber = adminModel.Phone;
        }

        await _dbContext.SaveChangesAsync();
    }

    public override async Task DeleteAsync(string id)
    {
        var admin = await _dbContext.Admins
            .Include(a => a.User)
            .FirstOrDefaultAsync(a => a.UserId == id);

        if (admin != null)
        {
            _dbContext.Admins.Remove(admin);

            if (admin.User != null)
                _dbContext.Users.Remove(admin.User);

            await _dbContext.SaveChangesAsync();
        }
    }
}