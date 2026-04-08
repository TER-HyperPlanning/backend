using HP2.Application.Contracts;
using HP2.Application.DTOs.Availability;
using HP2.Application.DTOs.Common;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AvailabilitiesController : ControllerBase
{
    private readonly IAvailabilityService _service;

    public AvailabilitiesController(IAvailabilityService service)
    {
        _service = service;
    }

    [HttpGet("teacher/{teacherId}")]
    public async Task<ActionResult<ApiResponse<IEnumerable<AvailabilityResponse>>>> GetByTeacher(string teacherId)
    {
        try
        {
            var data = await _service.GetByTeacherAsync(teacherId);
            return Ok(ApiResponse<IEnumerable<AvailabilityResponse>>.Success(data));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<IEnumerable<AvailabilityResponse>>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<IEnumerable<AvailabilityResponse>>.Fail($"Internal server error: {ex.Message}"));
        }
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<AvailabilityResponse>>> Create([FromBody] CreateAvailabilityRequest request)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => string.IsNullOrWhiteSpace(e.ErrorMessage) ? "Invalid request payload." : e.ErrorMessage)
                    .ToList();

                return BadRequest(ApiResponse<AvailabilityResponse>.Fail(string.Join(" | ", errors)));
            }

            var model = new AvailabilityModel
            {
                WeekDayId = request.WeekDayId,
                StartTime = request.StartTime,
                EndTime = request.EndTime,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                TeacherId = request.TeacherId
            };

            var result = await _service.CreateAsync(model);
            return Ok(ApiResponse<AvailabilityResponse>.Success(result, "Availability created successfully"));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<AvailabilityResponse>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<AvailabilityResponse>.Fail($"Internal server error: {ex.Message}"));
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<AvailabilityResponse>>> Update(string id, [FromBody] UpdateAvailabilityRequest request)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => string.IsNullOrWhiteSpace(e.ErrorMessage) ? "Invalid request payload." : e.ErrorMessage)
                    .ToList();

                return BadRequest(ApiResponse<AvailabilityResponse>.Fail(string.Join(" | ", errors)));
            }

            var model = new AvailabilityModel
            {
                Id = id,
                WeekDayId = request.WeekDayId,
                StartTime = request.StartTime,
                EndTime = request.EndTime,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                TeacherId = request.TeacherId
            };

            var result = await _service.UpdateAsync(id, model);
            return Ok(ApiResponse<AvailabilityResponse>.Success(result, "Availability updated successfully"));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<AvailabilityResponse>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<AvailabilityResponse>.Fail($"Internal server error: {ex.Message}"));
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        try
        {
            await _service.DeleteAsync(id);
            return Ok(ApiResponse<string>.Success(id, "Availability deleted successfully"));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<string>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<string>.Fail($"Internal server error: {ex.Message}"));
        }
    }
}