using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Session;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SessionsController : ControllerBase
{
    private readonly ISessionService _sessionService;

    public SessionsController(ISessionService sessionService)
    {
        _sessionService = sessionService;
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<SessionResponse>>> Create([FromBody] CreateSessionRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<SessionModel>.Fail("Session payload is required"));

        if (request.EndDateTime <= request.StartDateTime)
            return BadRequest(ApiResponse<SessionModel>.Fail("EndDateTime must be greater than StartDateTime"));

        if (request.StartDateTime.Date != request.EndDateTime.Date)
            return BadRequest(ApiResponse<SessionModel>.Fail("StartDateTime and EndDateTime must be on the same date"));

        var model = new SessionModel
        {
            Id = request.Id,
            StartDateTime = request.StartDateTime,
            EndDateTime = request.EndDateTime,
            Mode = request.Mode,
            SessionTypeId = request.SessionTypeId,
            CourseId = request.CourseId,
            SessionStatusId = request.SessionStatusId,
            RoomId = request.RoomId,
            Description = request.Description
        };

        var created = await _sessionService.CreateSessionAsync(model);

        return CreatedAtAction(nameof(Get), new { id = created.Id },
            ApiResponse<SessionResponse>.Success(MapToResponse(created), "Session created successfully"));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<SessionResponse>>> Get(string id)
    {
        var session = await _sessionService.GetSessionByIdAsync(id);
        if (session == null)
            return NotFound(ApiResponse<SessionModel>.Fail($"Session with ID {id} not found"));

        return Ok(ApiResponse<SessionResponse>.Success(MapToResponse(session)));
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<SessionResponse>>>> GetAll()
    {
        var sessions = await _sessionService.GetAllSessionsAsync();
        var responses = sessions.Select(MapToResponse);
        return Ok(ApiResponse<IEnumerable<SessionResponse>>.Success(responses));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<SessionResponse>>> Update(string id, [FromBody] UpdateSessionRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<SessionModel>.Fail("Session payload is required"));

        if (request.EndDateTime <= request.StartDateTime)
            return BadRequest(ApiResponse<SessionModel>.Fail("EndDateTime must be greater than StartDateTime"));

        if (request.StartDateTime.Date != request.EndDateTime.Date)
            return BadRequest(ApiResponse<SessionModel>.Fail("StartDateTime and EndDateTime must be on the same date"));

        var existing = await _sessionService.GetSessionByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<SessionModel>.Fail($"Session with ID {id} not found"));

        existing.StartDateTime = request.StartDateTime;
        existing.EndDateTime = request.EndDateTime;
        existing.Mode = request.Mode;
        existing.SessionTypeId = request.SessionTypeId;
        existing.CourseId = request.CourseId;
        existing.SessionStatusId = request.SessionStatusId;
        existing.RoomId = request.RoomId;
        existing.Description = request.Description;

        await _sessionService.UpdateSessionAsync(existing);

        return Ok(ApiResponse<SessionResponse>.Success(MapToResponse(existing), "Session updated successfully"));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        var existing = await _sessionService.GetSessionByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<string>.Fail($"Session with ID {id} not found"));

        await _sessionService.DeleteSessionAsync(id);
        return Ok(ApiResponse<string>.Success(id, "Session deleted successfully"));
    }

    private static SessionResponse MapToResponse(SessionModel s)
    {
        return new SessionResponse
        {
            Id = s.Id,
            StartDateTime = s.StartDateTime,
            EndDateTime = s.EndDateTime,
            Mode = s.Mode,
            Description = s.Description,

            Type = new ReferenceResponse { Id = s.SessionTypeId, Label = s.SessionTypeId },     // fallback
            Status = new ReferenceResponse { Id = s.SessionStatusId, Label = s.SessionStatusId }, // fallback
            Room = s.RoomId 
        };  
    }
}