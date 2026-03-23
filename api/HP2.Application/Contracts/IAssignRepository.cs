using HP2.Application.DTOs.Assign;

namespace HP2.Application.Contracts;

public interface IAssignRepository
{
    Task<List<AssignResponse>> GetAllAsync();
    Task<AssignResponse?> GetByIdsAsync(string trackId, string courseId);
    Task<bool> CreateAsync(string trackId, string courseId, int hourlyVolume);
    Task<bool> UpdateAsync(string trackId, string courseId, int hourlyVolume);
    Task<bool> DeleteAsync(string trackId, string courseId);
}