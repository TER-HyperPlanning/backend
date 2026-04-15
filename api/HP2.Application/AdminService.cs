using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Application.Security;

namespace HP2.Application;

public class AdminService : IAdminService
{
    private readonly IAdminRepository _adminRepository;
    private readonly IBCryptService _bcryptService;

    public AdminService(IAdminRepository adminRepository, IBCryptService bcryptService)
    {
        _adminRepository = adminRepository;
        _bcryptService = bcryptService;
    }

    public async Task<AdminModel> CreateAdminAsync(AdminModel admin)
    {
        if (!string.IsNullOrWhiteSpace(admin.Password))
        {
            admin.Password = _bcryptService.HashPassword(admin.Password);
        }
        return await _adminRepository.AddAsync(admin);
    }

    public async Task<AdminModel?> GetAdminByIdAsync(string id)
    {
        return await _adminRepository.GetByIdAsync(id);
    }

    public async Task<IReadOnlyList<AdminModel>> GetAllAdminsAsync()
    {
        return await _adminRepository.GetAllAsync();
    }

    public async Task<IReadOnlyList<AdminModel>> GetDeletedAdminsAsync()
    {
        return await _adminRepository.GetDeletedAsync();
    }

    public async Task UpdateAdminAsync(AdminModel admin)
    {
        await _adminRepository.UpdateAsync(admin);
    }

    public async Task DeleteAdminAsync(string id)
    {
        await _adminRepository.DeleteAsync(id);
    }
}