using HP2.Application.Contracts;
using HP2.Application.DTOs.Assign;
using HP2.Application.DTOs.Common;
using Microsoft.EntityFrameworkCore;

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
        try
        {
            var result = await _repository.GetAllAsync();
            return ApiResponse<List<AssignResponse>>.Success(result, "Assigns récupérés avec succès");
        }
        catch (Exception ex)
        {
            return ApiResponse<List<AssignResponse>>.Fail(ex.Message);
        }
    }

    public async Task<ApiResponse<AssignResponse>> GetByIdsAsync(string trackId, string courseId)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(trackId) || string.IsNullOrWhiteSpace(courseId))
                return ApiResponse<AssignResponse>.Fail("trackId et courseId sont obligatoires");

            var assign = await _repository.GetByIdsAsync(trackId, courseId);

            if (assign == null)
                return ApiResponse<AssignResponse>.Fail("Assign non trouvé");

            return ApiResponse<AssignResponse>.Success(assign, "Assign récupéré avec succès");
        }
        catch (Exception ex)
        {
            return ApiResponse<AssignResponse>.Fail(ex.Message);
        }
    }

    public async Task<ApiResponse<bool>> CreateAsync(CreateAssignRequest request)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(request.TrackId) ||
            string.IsNullOrWhiteSpace(request.CourseId))
            {
                return ApiResponse<bool>.Fail("trackId et courseId sont obligatoires");
            }

            if (request.HourlyVolume < 0)
            {
                return ApiResponse<bool>.Fail("hourlyVolume invalide");
            }
            var trackValid = await _repository.TrackExistsAsync(request.TrackId);
            var courseValid = await _repository.CourseExistsAsync(request.CourseId);
            
            if (!trackValid && !courseValid)
            {
                return ApiResponse<bool>.Fail("Le courseId et le trackId ne correspondent à aucune entité existante.");
            }
            if (!courseValid)
            {
                return ApiResponse<bool>.Fail("Le courseId ne correspond à aucun cours existant.");
            }
            if (!trackValid)
            {
                return ApiResponse<bool>.Fail("Le trackId ne correspond à aucun track existant.");
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
        catch
        {
            return ApiResponse<bool>.Fail("Une erreur interne est survenue.");
        }
    }

    public async Task<ApiResponse<bool>> UpdateAsync(string trackId, string courseId, UpdateAssignRequest request)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(trackId) || string.IsNullOrWhiteSpace(courseId))
            {
                return ApiResponse<bool>.Fail("trackId et courseId sont obligatoires");
            }

            if (request == null)
            {
                return ApiResponse<bool>.Fail("Le body est obligatoire");
            }

            if (request.HourlyVolume < 0)
            {
                return ApiResponse<bool>.Fail("hourlyVolume invalide");
            }

            var existingAssign = await _repository.GetByIdsAsync(trackId, courseId);

            if (existingAssign == null)
            {
                return ApiResponse<bool>.Fail("Assign non trouvé");
            }

            var result = await _repository.UpdateAsync(
                trackId,
                courseId,
                request.HourlyVolume
            );

            return ApiResponse<bool>.Success(true, "Assign mis à jour");
        }
        catch (Exception ex)
        {
            return ApiResponse<bool>.Fail(ex.Message);
        }
    }

    public async Task<ApiResponse<bool>> DeleteAsync(string trackId, string courseId)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(trackId) || string.IsNullOrWhiteSpace(courseId))
                return ApiResponse<bool>.Fail("trackId et courseId sont obligatoires");

            var existingAssign = await _repository.GetByIdsAsync(trackId, courseId);

            if (existingAssign == null)
            {
                return ApiResponse<bool>.Fail("Assign non trouvé");
            }

            var result = await _repository.DeleteAsync(trackId, courseId);

            return ApiResponse<bool>.Success(true, "Assign supprimé");
        }
        catch (Exception ex)
        {
            return ApiResponse<bool>.Fail(ex.Message);
        }
    }
}