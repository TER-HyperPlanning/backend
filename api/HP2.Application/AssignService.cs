using HP2.Application.Contracts;
using HP2.Application.DTOs.Assign;
using HP2.Application.DTOs.Common;
using Microsoft.EntityFrameworkCore;
using HP2.Domain.Models;

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
            return ApiResponse<List<AssignResponse>>.Success(result, "Assigns retrieved successfully");
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
                return ApiResponse<AssignResponse>.Fail("trackId and courseId are required.");

            var assign = await _repository.GetByIdsAsync(trackId, courseId);

            if (assign == null)
                return ApiResponse<AssignResponse>.Fail($"Assign with Track ID {trackId} and Course ID {courseId} was not found.");

            return ApiResponse<AssignResponse>.Success(assign, "Assign retrieved successfully");
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
                return ApiResponse<bool>.Fail("trackId and courseId are required.");
            }

            if (request.HourlyVolume < 0)
            {
                return ApiResponse<bool>.Fail("hourlyVolume is invalid.");
            }
            var trackValid = await _repository.TrackExistsAsync(request.TrackId);
            var courseValid = await _repository.CourseExistsAsync(request.CourseId);
            
            if (!trackValid && !courseValid)
            {
                return ApiResponse<bool>.Fail($"Track with ID {request.TrackId} and Course with ID {request.CourseId} do not exist.");
            }
            if (!courseValid)
            {
                return ApiResponse<bool>.Fail($"Course with ID {request.CourseId} does not exist.");
            }
            if (!trackValid)
            {
                return ApiResponse<bool>.Fail($"Track with ID {request.TrackId} does not exist.");
            }
            var result = await _repository.CreateAsync(
                request.TrackId,
                request.CourseId,
                request.HourlyVolume
            );
            
            if (!result)
            return ApiResponse<bool>.Fail("An error occurred while creating the assign.");
            return ApiResponse<bool>.Success(true, "Assign created successfully");
        }
        catch
        {
            return ApiResponse<bool>.Fail("An internal error occurred.");
        }
    }

    public async Task<ApiResponse<bool>> UpdateAsync(string trackId, string courseId, UpdateAssignRequest request)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(trackId) || string.IsNullOrWhiteSpace(courseId))
            {
                return ApiResponse<bool>.Fail("trackId and courseId are required.");
            }

            if (request == null)
            {
                return ApiResponse<bool>.Fail("Request body is required.");
            }

            if (request.HourlyVolume < 0)
            {
                return ApiResponse<bool>.Fail("hourlyVolume is invalid.");
            }

            var existingAssign = await _repository.GetByIdsAsync(trackId, courseId);

            if (existingAssign == null)
            {
                return ApiResponse<bool>.Fail($"Assign with Track ID {trackId} and Course ID {courseId} does not exist.");
            }

            var result = await _repository.UpdateAsync(
                trackId,
                courseId,
                request.HourlyVolume
            );

            return ApiResponse<bool>.Success(true, "Assign updated successfully");
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
                return ApiResponse<bool>.Fail("trackId and courseId are required.");

            var existingAssign = await _repository.GetByIdsAsync(trackId, courseId);

            if (existingAssign == null)
            {
                return ApiResponse<bool>.Fail($"Assign with Track ID {trackId} and Course ID {courseId} was not found.");
            }

            var result = await _repository.DeleteAsync(trackId, courseId);

            return ApiResponse<bool>.Success(true, "Assign deleted successfully");
        }
        catch (Exception ex)
        {
            return ApiResponse<bool>.Fail(ex.Message);
        }
    }

    public async Task<ApiResponse<List<AssignResponse>>> GetDeletedAsync()
    {
        try
        {
            var result = await _repository.GetDeletedAsync();
            return ApiResponse<List<AssignResponse>>.Success(result, "Deleted assigns retrieved");
        }
        catch (Exception ex)
        {
            return ApiResponse<List<AssignResponse>>.Fail(ex.Message);
        }
    }
}