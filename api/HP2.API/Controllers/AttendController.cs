using HP2.Application.Contracts;
using HP2.Application.DTOs.Attend;
using HP2.Application.DTOs.Common;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AttendsController : ControllerBase
{
    private readonly IAttendService _attendService;

    public AttendsController(IAttendService attendService)
    {
        _attendService = attendService;
    }

    [HttpPost]
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<AttendResponse>>> Create([FromBody] CreateAttendRequest request)
    {
        if (request == null)
        {
            return BadRequest(ApiResponse<AttendResponse>.Fail("Attend payload is required"));
        }

        var missing = new List<string>();
        if (string.IsNullOrWhiteSpace(request.GroupId)) missing.Add("groupId");
        if (string.IsNullOrWhiteSpace(request.SessionId)) missing.Add("sessionId");
        if (missing.Any())
        {
            return BadRequest(ApiResponse<AttendResponse>.Fail($"Missing required fields: {string.Join(", ", missing)}"));
        }

        if (!await _attendService.GroupExistsAsync(request.GroupId))
        {
            return NotFound(ApiResponse<AttendResponse>.Fail($"Group with ID {request.GroupId} not found"));
        }

        if (!await _attendService.SessionExistsAsync(request.SessionId))
        {
            return NotFound(ApiResponse<AttendResponse>.Fail($"Session with ID {request.SessionId} not found"));
        }

        if (await _attendService.ExistsAsync(request.GroupId, request.SessionId))
        {
            return Conflict(ApiResponse<AttendResponse>.Fail("This session is already assigned to this group"));
        }

        try
        {
            var created = await _attendService.AddAsync(new AttendModel
            {
                GroupId = request.GroupId,
                SessionId = request.SessionId
            });

            var response = new AttendResponse
            {
                GroupId = created.GroupId,
                SessionId = created.SessionId
            };

            return Ok(ApiResponse<AttendResponse>.Success(response, "Attend created successfully"));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<AttendResponse>.Fail(ex.Message));
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(ApiResponse<AttendResponse>.Fail(ex.Message));
        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<AttendResponse>.Fail("Internal server error"));
        }
    }

    [HttpPut]
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<AttendResponse>>> Update([FromBody] UpdateAttendRequest request)
    {
        if (request == null)
        {
            return BadRequest(ApiResponse<AttendResponse>.Fail("Attend payload is required"));
        }

        var missing = new List<string>();
        if (string.IsNullOrWhiteSpace(request.CurrentGroupId)) missing.Add("currentGroupId");
        if (string.IsNullOrWhiteSpace(request.CurrentSessionId)) missing.Add("currentSessionId");
        if (string.IsNullOrWhiteSpace(request.GroupId)) missing.Add("groupId");
        if (string.IsNullOrWhiteSpace(request.SessionId)) missing.Add("sessionId");
        if (missing.Any())
        {
            return BadRequest(ApiResponse<AttendResponse>.Fail($"Missing required fields: {string.Join(", ", missing)}"));
        }

        if (!await _attendService.ExistsAsync(request.CurrentGroupId, request.CurrentSessionId))
        {
            return NotFound(ApiResponse<AttendResponse>.Fail("Attend relation not found"));
        }

        if (!await _attendService.GroupExistsAsync(request.GroupId))
        {
            return NotFound(ApiResponse<AttendResponse>.Fail($"Group with ID {request.GroupId} not found"));
        }

        if (!await _attendService.SessionExistsAsync(request.SessionId))
        {
            return NotFound(ApiResponse<AttendResponse>.Fail($"Session with ID {request.SessionId} not found"));
        }

        if ((request.CurrentGroupId != request.GroupId || request.CurrentSessionId != request.SessionId)
            && await _attendService.ExistsAsync(request.GroupId, request.SessionId))
        {
            return Conflict(ApiResponse<AttendResponse>.Fail("This session is already assigned to this group"));
        }

        try
        {
            var updated = await _attendService.UpdateAsync(
                request.CurrentGroupId,
                request.CurrentSessionId,
                new AttendModel
                {
                    GroupId = request.GroupId,
                    SessionId = request.SessionId
                });

            var response = new AttendResponse
            {
                GroupId = updated.GroupId,
                SessionId = updated.SessionId
            };

            return Ok(ApiResponse<AttendResponse>.Success(response, "Attend updated successfully"));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<AttendResponse>.Fail(ex.Message));
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ApiResponse<AttendResponse>.Fail(ex.Message));
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(ApiResponse<AttendResponse>.Fail(ex.Message));
        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<AttendResponse>.Fail("Internal server error"));
        }
    }

    [HttpGet]
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<IEnumerable<AttendResponse>>>> GetAll()
    {
        var rows = await _attendService.GetAllAsync();
        var response = rows.Select(x => new AttendResponse
        {
            GroupId = x.GroupId,
            SessionId = x.SessionId
        });

        return Ok(ApiResponse<IEnumerable<AttendResponse>>.Success(response));
    }

    [HttpGet("group/{groupId}")]
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<IEnumerable<AttendResponse>>>> GetByGroupId(string groupId)
    {
        if (string.IsNullOrWhiteSpace(groupId))
        {
            return BadRequest(ApiResponse<IEnumerable<AttendResponse>>.Fail("groupId is required"));
        }

        if (!await _attendService.GroupExistsAsync(groupId))
        {
            return NotFound(ApiResponse<IEnumerable<AttendResponse>>.Fail($"Group with ID {groupId} not found"));
        }

        var rows = await _attendService.GetByGroupIdAsync(groupId);
        var response = rows.Select(x => new AttendResponse
        {
            GroupId = x.GroupId,
            SessionId = x.SessionId
        });

        return Ok(ApiResponse<IEnumerable<AttendResponse>>.Success(response));
    }

    [HttpGet("session/{sessionId}")]
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<IEnumerable<AttendResponse>>>> GetBySessionId(string sessionId)
    {
        if (string.IsNullOrWhiteSpace(sessionId))
        {
            return BadRequest(ApiResponse<IEnumerable<AttendResponse>>.Fail("sessionId is required"));
        }

        if (!await _attendService.SessionExistsAsync(sessionId))
        {
            return NotFound(ApiResponse<IEnumerable<AttendResponse>>.Fail($"Session with ID {sessionId} not found"));
        }

        var rows = await _attendService.GetBySessionIdAsync(sessionId);
        var response = rows.Select(x => new AttendResponse
        {
            GroupId = x.GroupId,
            SessionId = x.SessionId
        });

        return Ok(ApiResponse<IEnumerable<AttendResponse>>.Success(response));
    }

    [HttpDelete]
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<string>>> Delete([FromQuery] string groupId, [FromQuery] string sessionId)
    {
        if (string.IsNullOrWhiteSpace(groupId) || string.IsNullOrWhiteSpace(sessionId))
        {
            return BadRequest(ApiResponse<string>.Fail("groupId and sessionId are required"));
        }

        var deleted = await _attendService.DeleteAsync(groupId, sessionId);
        if (!deleted)
        {
            return NotFound(ApiResponse<string>.Fail("Attend relation not found"));
        }

        return Ok(ApiResponse<string>.Success(string.Empty, "Attend deleted successfully"));
    }
}
