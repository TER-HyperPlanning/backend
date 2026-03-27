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
        var data = await _service.GetByTeacherAsync(teacherId);
        return Ok(ApiResponse<IEnumerable<AvailabilityResponse>>.Success(data));
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<AvailabilityResponse>>> Create([FromBody] CreateAvailabilityRequest request)
    {
        try
        {
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
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<AvailabilityResponse>>> Update(string id, [FromBody] UpdateAvailabilityRequest request)
    {
        try
        {
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
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        await _service.DeleteAsync(id);
        return Ok(ApiResponse<string>.Success(id, "Availability deleted successfully"));
    }
}