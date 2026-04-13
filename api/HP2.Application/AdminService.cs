using HP2.Application.Contracts;
using HP2.Domain.Models;

namespace HP2.Application;

public class AdminService : IAdminService
{
    private readonly IAdminRepository _adminRepository;

    public AdminService(IAdminRepository adminRepository)
    {
        _adminRepository = adminRepository;
    }

    public async Task<AdminModel> CreateAdminAsync(AdminModel admin)
    {
        return await _adminRepository.AddAsync(admin);
    }

    public async Task<AdminModel?> GetAdminByIdAsync(string id)
    {
        return await _adminRepository.GetByIdAsync(id);
    }

    public async Task<IReadOnlyList<AdminModel>> GetAllAdminsAsync(string? firstName, string? lastName)
    {
        return await _adminRepository.GetAllFilteredAsync(firstName, lastName);
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