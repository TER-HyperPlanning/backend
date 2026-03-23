using HP2.Application.Contracts;
using HP2.Application.DTOs.Assign;
using HP2.Application.DTOs.Common;

namespace HP2.Application;

public class AssignService : IAssignService
{
    private readonly IAssignRepository _repository;

    public AssignService(IAssignRepository repository)
    {
        _repository = repository;
    }

    public async Task<ApiResponse<List<AssignResponse>>> GetAllAsync()
    {
        var result = await _repository.GetAllAsync();
        return ApiResponse<List<AssignResponse>>.Success(result);
    }

    public async Task<ApiResponse<AssignResponse>> GetByIdsAsync(string trackId, string courseId)
    {
        if (string.IsNullOrWhiteSpace(trackId) || string.IsNullOrWhiteSpace(courseId))
            return ApiResponse<AssignResponse>.Fail("track_id et course_id sont obligatoires");

        var assign = await _repository.GetByIdsAsync(trackId, courseId);

        if (assign == null)
            return ApiResponse<AssignResponse>.Fail("Assign non trouvé");

        return ApiResponse<AssignResponse>.Success(assign);
    }

    public async Task<ApiResponse<bool>> CreateAsync(CreateAssignRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.TrackId) ||
            string.IsNullOrWhiteSpace(request.CourseId) ||
            request.HourlyVolume <= 0)
        {
            return ApiResponse<bool>.Fail("Tous les champs sont obligatoires");
        }

        var result = await _repository.CreateAsync(
            request.TrackId,
            request.CourseId,
            request.HourlyVolume
        );

        if (!result)
            return ApiResponse<bool>.Fail("Erreur lors de la création");

        return ApiResponse<bool>.Success(true, "Assign créé avec succès");
    }

    public async Task<ApiResponse<bool>> UpdateAsync(UpdateAssignRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.TrackId) ||
            string.IsNullOrWhiteSpace(request.CourseId) ||
            request.HourlyVolume <= 0)
        {
            return ApiResponse<bool>.Fail("Tous les champs sont obligatoires");
        }

        var result = await _repository.UpdateAsync(
            request.TrackId,
            request.CourseId,
            request.HourlyVolume
        );

        if (!result)
            return ApiResponse<bool>.Fail("Erreur lors de la mise à jour");

        return ApiResponse<bool>.Success(true, "Assign mis à jour");
    }

    public async Task<ApiResponse<bool>> DeleteAsync(string trackId, string courseId)
    {
        if (string.IsNullOrWhiteSpace(trackId) || string.IsNullOrWhiteSpace(courseId))
            return ApiResponse<bool>.Fail("track_id et course_id sont obligatoires");

        var result = await _repository.DeleteAsync(trackId, courseId);

        if (!result)
            return ApiResponse<bool>.Fail("Erreur lors de la suppression");

        return ApiResponse<bool>.Success(true, "Assign supprimé");
    }
}