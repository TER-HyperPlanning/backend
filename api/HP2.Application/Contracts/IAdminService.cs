using HP2.Domain.Models;

namespace HP2.Application.Contracts;

public interface IAdminService
{
    Task<AdminModel> CreateAdminAsync(AdminModel admin);
    Task<AdminModel?> GetAdminByIdAsync(string id);
    Task<IReadOnlyList<AdminModel>> GetAllAdminsAsync(string? firstName, string? lastName);
    Task<IReadOnlyList<AdminModel>> GetDeletedAdminsAsync();
    Task UpdateAdminAsync(AdminModel admin);
    Task DeleteAdminAsync(string id);
}