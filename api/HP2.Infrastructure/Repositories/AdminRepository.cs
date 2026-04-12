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

    public async Task<IReadOnlyList<AdminModel>> GetDeletedAsync()
    {
        var deletedAdmins = await _dbContext.Admins
            .IgnoreQueryFilters()
            .Include(a => a.User)
            .ThenInclude(u => u.UserRole)
            .Where(a => a.User != null && a.User.IsDeleted)
            .ToListAsync();

        return _mapper.Map<List<AdminModel>>(deletedAdmins);
    }

    public override async Task<AdminModel> AddAsync(AdminModel adminModel)
    {
        var emailExists = await _dbContext.Users
            .AnyAsync(u => u.Email == adminModel.Email);
        
        if (emailExists)
            throw new Exception("Email already exists");

        var adminRole = await _dbContext.UserRoles.FirstOrDefaultAsync(r => r.Name == "ADMIN");
        if (adminRole == null)
            throw new Exception("Admin role not found");

        var user = new User
        {
            UserId = Guid.NewGuid().ToString(),
            Email = adminModel.Email,
            Password = adminModel.Password,
            FirstName = adminModel.FirstName,
            LastName = adminModel.LastName,
            PhoneNumber = adminModel.Phone,
            UserRoleId = adminRole.UserRoleId,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            IsDeleted = false,
            DeletedAt = null
        };

        var admin = new Admin
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

        if (admin == null)
            return;

        var emailExists = await _dbContext.Users
            .AnyAsync(u => u.Email == adminModel.Email && u.UserId != adminModel.Id);

        if (emailExists)
            throw new Exception("Email already exists");

        if (admin.User != null)
        {
            admin.User.Email = adminModel.Email;
            admin.User.FirstName = adminModel.FirstName;
            admin.User.LastName = adminModel.LastName;
            admin.User.PhoneNumber = adminModel.Phone;
            admin.User.UpdatedAt = DateTime.UtcNow;
            admin.User.IsDeleted = adminModel.IsDeleted;
            admin.User.DeletedAt = adminModel.DeletedAt;
        }

        await _dbContext.SaveChangesAsync();
    }

    public override async Task DeleteAsync(string id)
    {
        await base.DeleteAsync(id);
    }
}