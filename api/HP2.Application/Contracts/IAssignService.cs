using HP2.Application.DTOs.Assign;
using HP2.Application.DTOs.Common;

namespace HP2.Application.Contracts;

public interface IAssignService
{
    Task<ApiResponse<List<AssignResponse>>> GetAllAsync();
    Task<ApiResponse<AssignResponse>> GetByIdsAsync(string trackId, string courseId);
    Task<ApiResponse<bool>> CreateAsync(CreateAssignRequest request);
    Task<ApiResponse<bool>> UpdateAsync(UpdateAssignRequest request);
    Task<ApiResponse<bool>> DeleteAsync(string trackId, string courseId);
}