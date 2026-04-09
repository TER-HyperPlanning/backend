using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.SessionChange;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SessionChangesController : ControllerBase
{
    private readonly ISessionChangeService _sessionChangeService;

    public SessionChangesController(ISessionChangeService sessionChangeService)
    {
        _sessionChangeService = sessionChangeService;
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<SessionChangeListResponse>>>> GetAll()
    {
        try
        {
            var data = await _sessionChangeService.GetAllAsync();
            return Ok(ApiResponse<IEnumerable<SessionChangeListResponse>>.Success(data, "Session change requests retrieved successfully."));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<IEnumerable<SessionChangeListResponse>>.Fail($"Server error: {ex.Message}"));
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<SessionChangeDetailsResponse>>> GetById(string id)
    {
        try
        {
            var item = await _sessionChangeService.GetByIdAsync(id);

            if (item == null)
                return NotFound(ApiResponse<SessionChangeDetailsResponse>.Fail("Session change request not found."));

            return Ok(ApiResponse<SessionChangeDetailsResponse>.Success(item, "Session change request retrieved successfully."));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<SessionChangeDetailsResponse>.Fail($"Server error: {ex.Message}"));
        }
    }

    [HttpPost("{id}/approve-room")]
    public async Task<ActionResult<ApiResponse<string>>> ApproveRoomChange(string id, [FromBody] ApproveRoomChangeRequest request)
    {
        try
        {
            await _sessionChangeService.ApproveRoomChangeAsync(id, request.RoomId);
            return Ok(ApiResponse<string>.Success(id, "Room change approved successfully."));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<string>.Fail(ex.Message));
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ApiResponse<string>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<string>.Fail($"Server error: {ex.Message}"));
        }
    }

    [HttpPost("{id}/approve-recovery")]
    public async Task<ActionResult<ApiResponse<string>>> ApproveRecovery(string id)
    {
        try
        {
            await _sessionChangeService.ApproveRecoveryAsync(id);
            return Ok(ApiResponse<string>.Success(id, "Recovery request approved successfully."));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<string>.Fail(ex.Message));
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ApiResponse<string>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<string>.Fail($"Server error: {ex.Message}"));
        }
    }

    [HttpPost("{id}/reject")]
    public async Task<ActionResult<ApiResponse<string>>> Reject(string id, [FromBody] RejectSessionChangeRequest request)
    {
        try
        {
            await _sessionChangeService.RejectAsync(id, request.RejectionReason);
            return Ok(ApiResponse<string>.Success(id, "Session change request rejected successfully."));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<string>.Fail(ex.Message));
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ApiResponse<string>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<string>.Fail($"Server error: {ex.Message}"));
        }
    }

    [HttpPost("{id}/counter-proposal")]
    public async Task<ActionResult<ApiResponse<string>>> CounterProposal(string id, [FromBody] CounterProposalRequest request)
    {
        try
        {
            await _sessionChangeService.CounterProposeAsync(
                id,
                request.Date,
                request.StartTime,
                request.EndTime,
                request.RoomId);

            return Ok(ApiResponse<string>.Success(id, "Counter proposal submitted successfully."));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<string>.Fail(ex.Message));
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ApiResponse<string>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<string>.Fail($"Server error: {ex.Message}"));
        }
    }
}