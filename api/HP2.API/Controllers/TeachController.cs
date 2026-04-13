using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Teach;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeachesController : ControllerBase
{
    private readonly ITeachService _teachService;

    public TeachesController(ITeachService teachService)
    {
        _teachService = teachService;
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<TeachResponse>>> Create([FromBody] CreateTeachRequest request)
    {
        if (request == null)
        {
            return BadRequest(ApiResponse<TeachResponse>.Fail("Teach payload is required"));
        }

        var missing = new List<string>();
        if (string.IsNullOrWhiteSpace(request.SessionId)) missing.Add("sessionId");
        if (string.IsNullOrWhiteSpace(request.TeacherId)) missing.Add("teacherId");
        if (missing.Any())
        {
            return BadRequest(ApiResponse<TeachResponse>.Fail($"Missing required fields: {string.Join(", ", missing)}"));
        }

        if (!await _teachService.SessionExistsAsync(request.SessionId))
        {
            return NotFound(ApiResponse<TeachResponse>.Fail($"Session with ID {request.SessionId} not found"));
        }

        if (!await _teachService.TeacherExistsAsync(request.TeacherId))
        {
            return NotFound(ApiResponse<TeachResponse>.Fail($"Teacher with ID {request.TeacherId} not found"));
        }

        if (await _teachService.ExistsAsync(request.SessionId, request.TeacherId))
        {
            return Conflict(ApiResponse<TeachResponse>.Fail("This teacher is already assigned to this session"));
        }

        try
        {
            var created = await _teachService.AddAsync(new TeachModel
            {
                SessionId = request.SessionId,
                TeacherId = request.TeacherId
            });

            var response = new TeachResponse
            {
                SessionId = created.SessionId,
                TeacherId = created.TeacherId,
                DeletedAt = created.DeletedAt
            };

            return Ok(ApiResponse<TeachResponse>.Success(response, "Teach created successfully"));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<TeachResponse>.Fail(ex.Message));
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(ApiResponse<TeachResponse>.Fail(ex.Message));
        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<TeachResponse>.Fail("Internal server error"));
        }
    }

    [HttpPut]
    public async Task<ActionResult<ApiResponse<TeachResponse>>> Update([FromBody] UpdateTeachRequest request)
    {
        if (request == null)
        {
            return BadRequest(ApiResponse<TeachResponse>.Fail("Teach payload is required"));
        }

        var missing = new List<string>();
        if (string.IsNullOrWhiteSpace(request.CurrentSessionId)) missing.Add("currentSessionId");
        if (string.IsNullOrWhiteSpace(request.CurrentTeacherId)) missing.Add("currentTeacherId");
        if (string.IsNullOrWhiteSpace(request.SessionId)) missing.Add("sessionId");
        if (string.IsNullOrWhiteSpace(request.TeacherId)) missing.Add("teacherId");
        if (missing.Any())
        {
            return BadRequest(ApiResponse<TeachResponse>.Fail($"Missing required fields: {string.Join(", ", missing)}"));
        }

        if (!await _teachService.ExistsAsync(request.CurrentSessionId, request.CurrentTeacherId))
        {
            return NotFound(ApiResponse<TeachResponse>.Fail("Teach relation not found"));
        }

        if (!await _teachService.SessionExistsAsync(request.SessionId))
        {
            return NotFound(ApiResponse<TeachResponse>.Fail($"Session with ID {request.SessionId} not found"));
        }

        if (!await _teachService.TeacherExistsAsync(request.TeacherId))
        {
            return NotFound(ApiResponse<TeachResponse>.Fail($"Teacher with ID {request.TeacherId} not found"));
        }

        if ((request.CurrentSessionId != request.SessionId || request.CurrentTeacherId != request.TeacherId)
            && await _teachService.ExistsAsync(request.SessionId, request.TeacherId))
        {
            return Conflict(ApiResponse<TeachResponse>.Fail("This teacher is already assigned to this session"));
        }

        try
        {
            var updated = await _teachService.UpdateAsync(
                request.CurrentSessionId,
                request.CurrentTeacherId,
                new TeachModel
                {
                    SessionId = request.SessionId,
                    TeacherId = request.TeacherId
                });

            var response = new TeachResponse
            {
                SessionId = updated.SessionId,
                TeacherId = updated.TeacherId,
                DeletedAt = updated.DeletedAt
            };

            return Ok(ApiResponse<TeachResponse>.Success(response, "Teach updated successfully"));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<TeachResponse>.Fail(ex.Message));
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ApiResponse<TeachResponse>.Fail(ex.Message));
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(ApiResponse<TeachResponse>.Fail(ex.Message));
        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<TeachResponse>.Fail("Internal server error"));
        }
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<TeachResponse>>>> GetAll()
    {
        var rows = await _teachService.GetAllAsync();
        var response = rows.Select(x => new TeachResponse
        {
            SessionId = x.SessionId,
            TeacherId = x.TeacherId,
            DeletedAt = x.DeletedAt
        });

        return Ok(ApiResponse<IEnumerable<TeachResponse>>.Success(response));
    }

    [HttpGet("deleted")]
    public async Task<ActionResult<ApiResponse<IEnumerable<DeletedTeachResponse>>>> GetDeleted()
    {
        var rows = await _teachService.GetDeletedAsync();
        var response = rows.Select(x => new DeletedTeachResponse
        {
            SessionId = x.SessionId,
            TeacherId = x.TeacherId,
            DeletedAt = x.DeletedAt
        });

        return Ok(ApiResponse<IEnumerable<DeletedTeachResponse>>.Success(response));
    }

    [HttpGet("session/{sessionId}")]
    public async Task<ActionResult<ApiResponse<IEnumerable<TeachResponse>>>> GetBySessionId(string sessionId)
    {
        if (string.IsNullOrWhiteSpace(sessionId))
        {
            return BadRequest(ApiResponse<IEnumerable<TeachResponse>>.Fail("sessionId is required"));
        }

        if (!await _teachService.SessionExistsAsync(sessionId))
        {
            return NotFound(ApiResponse<IEnumerable<TeachResponse>>.Fail($"Session with ID {sessionId} not found"));
        }

        var rows = await _teachService.GetBySessionIdAsync(sessionId);
        var response = rows.Select(x => new TeachResponse
        {
            SessionId = x.SessionId,
            TeacherId = x.TeacherId,
            DeletedAt = x.DeletedAt
        });

        return Ok(ApiResponse<IEnumerable<TeachResponse>>.Success(response));
    }

    [HttpGet("teacher/{teacherId}")]
    public async Task<ActionResult<ApiResponse<IEnumerable<TeachResponse>>>> GetByTeacherId(string teacherId)
    {
        if (string.IsNullOrWhiteSpace(teacherId))
        {
            return BadRequest(ApiResponse<IEnumerable<TeachResponse>>.Fail("teacherId is required"));
        }

        if (!await _teachService.TeacherExistsAsync(teacherId))
        {
            return NotFound(ApiResponse<IEnumerable<TeachResponse>>.Fail($"Teacher with ID {teacherId} not found"));
        }

        var rows = await _teachService.GetByTeacherIdAsync(teacherId);
        var response = rows.Select(x => new TeachResponse
        {
            SessionId = x.SessionId,
            TeacherId = x.TeacherId,
            DeletedAt = x.DeletedAt
        });

        return Ok(ApiResponse<IEnumerable<TeachResponse>>.Success(response));
    }

    [HttpDelete]
    public async Task<ActionResult<ApiResponse<string>>> Delete([FromQuery] string sessionId, [FromQuery] string teacherId)
    {
        if (string.IsNullOrWhiteSpace(sessionId) || string.IsNullOrWhiteSpace(teacherId))
        {
            return BadRequest(ApiResponse<string>.Fail("sessionId and teacherId are required"));
        }

        var deleted = await _teachService.DeleteAsync(sessionId, teacherId);
        if (!deleted)
        {
            return NotFound(ApiResponse<string>.Fail("Teach relation not found"));
        }

        return Ok(ApiResponse<string>.Success(string.Empty, "Teach deleted successfully"));
    }
}
