using HP2.Application.Contracts;
using HP2.Application.DTOs.Availability;
using HP2.Application.DTOs.Common;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AvailabilityGroupsController : ControllerBase
{
    private readonly IAvailabilityGroupService _service;

    public AvailabilityGroupsController(IAvailabilityGroupService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<AvailabilityGroupResponse>>> GetById(string id)
    {
        try
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null)
                return NotFound(ApiResponse<AvailabilityGroupResponse>.Fail("Availability group not found."));

            return Ok(ApiResponse<AvailabilityGroupResponse>.Success(result));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<AvailabilityGroupResponse>.Fail($"Internal server error: {ex.Message}"));
        }
    }

    [HttpGet("teacher/{teacherId}")]
    public async Task<ActionResult<ApiResponse<IEnumerable<AvailabilityGroupResponse>>>> GetByTeacher(string teacherId)
    {
        try
        {
            var data = await _service.GetByTeacherAsync(teacherId);
            return Ok(ApiResponse<IEnumerable<AvailabilityGroupResponse>>.Success(data));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<IEnumerable<AvailabilityGroupResponse>>.Fail($"Internal server error: {ex.Message}"));
        }
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<AvailabilityGroupResponse>>> Create([FromBody] CreateAvailabilityGroupRequest request)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => string.IsNullOrWhiteSpace(e.ErrorMessage) ? "Invalid request payload." : e.ErrorMessage)
                    .ToList();

                return BadRequest(ApiResponse<AvailabilityGroupResponse>.Fail(string.Join(" | ", errors)));
            }

            var model = new AvailabilityGroupModel
            {
                TeacherId = request.TeacherId,
                NumberOfAvailableDays = request.NumberOfAvailableDays
            };

            var result = await _service.CreateAsync(model);
            return Ok(ApiResponse<AvailabilityGroupResponse>.Success(result, "Availability group created successfully."));
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ApiResponse<AvailabilityGroupResponse>.Fail(ex.Message));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<AvailabilityGroupResponse>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<AvailabilityGroupResponse>.Fail($"Internal server error: {ex.Message}"));
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<AvailabilityGroupResponse>>> Update(string id, [FromBody] UpdateAvailabilityGroupRequest request)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => string.IsNullOrWhiteSpace(e.ErrorMessage) ? "Invalid request payload." : e.ErrorMessage)
                    .ToList();

                return BadRequest(ApiResponse<AvailabilityGroupResponse>.Fail(string.Join(" | ", errors)));
            }

            var model = new AvailabilityGroupModel
            {
                Id = id,
                NumberOfAvailableDays = request.NumberOfAvailableDays
            };

            var result = await _service.UpdateAsync(id, model);
            return Ok(ApiResponse<AvailabilityGroupResponse>.Success(result, "Availability group updated successfully."));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<AvailabilityGroupResponse>.Fail(ex.Message));
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ApiResponse<AvailabilityGroupResponse>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<AvailabilityGroupResponse>.Fail($"Internal server error: {ex.Message}"));
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        try
        {
            await _service.DeleteAsync(id);
            return Ok(ApiResponse<string>.Success(id, "Availability group deleted successfully."));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<string>.Fail($"Internal server error: {ex.Message}"));
        }
    }
}
