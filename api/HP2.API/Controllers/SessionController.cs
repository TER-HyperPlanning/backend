using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Session;
using HP2.Application.Helpers;
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
            return BadRequest(ApiResponse<SessionResponse>.Fail("Session payload is required"));

        if (request.EndDateTime <= request.StartDateTime)
            return BadRequest(ApiResponse<SessionResponse>.Fail("EndDateTime must be greater than StartDateTime"));

        if (request.StartDateTime.Date != request.EndDateTime.Date)
            return BadRequest(ApiResponse<SessionResponse>.Fail("StartDateTime and EndDateTime must be on the same date"));

        var sessionTypeLabel = SessionReferenceMapper.ToLabel(request.SessionType);
        var sessionStatusLabel = SessionReferenceMapper.ToLabel(request.SessionStatus);

        var sessionTypeId = await _sessionService.GetSessionTypeIdAsync(sessionTypeLabel);
        var sessionStatusId = await _sessionService.GetSessionStatusIdAsync(sessionStatusLabel);

        if (sessionTypeId == null)
            return BadRequest(ApiResponse<SessionResponse>.Fail($"SessionType '{sessionTypeLabel}' not found"));

        if (sessionStatusId == null)
            return BadRequest(ApiResponse<SessionResponse>.Fail($"SessionStatus '{sessionStatusLabel}' not found"));

        var model = new SessionModel
        {
            StartDateTime = request.StartDateTime,
            EndDateTime = request.EndDateTime,
            Mode = request.Mode,
            SessionTypeId = sessionTypeId,
            CourseId = request.CourseId,
            SessionStatusId = sessionStatusId,
            RoomId = request.RoomId,
            Description = request.Description
        };

        var created = await _sessionService.CreateSessionAsync(model);
        var createdFull = await _sessionService.GetSessionByIdAsync(created.Id);

        return CreatedAtAction(nameof(Get), new { id = created.Id },
            ApiResponse<SessionResponse>.Success(MapToResponse(createdFull!), "Session created successfully"));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<SessionResponse>>> Get(string id)
    {
        var session = await _sessionService.GetSessionByIdAsync(id);
        if (session == null)
            return NotFound(ApiResponse<SessionResponse>.Fail($"Session with ID {id} not found"));

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
            return BadRequest(ApiResponse<SessionResponse>.Fail("Session payload is required"));

        if (request.EndDateTime <= request.StartDateTime)
            return BadRequest(ApiResponse<SessionResponse>.Fail("EndDateTime must be greater than StartDateTime"));

        if (request.StartDateTime.Date != request.EndDateTime.Date)
            return BadRequest(ApiResponse<SessionResponse>.Fail("StartDateTime and EndDateTime must be on the same date"));

        var existing = await _sessionService.GetSessionByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<SessionResponse>.Fail($"Session with ID {id} not found"));

        var sessionTypeLabel = SessionReferenceMapper.ToLabel(request.SessionType);
        var sessionStatusLabel = SessionReferenceMapper.ToLabel(request.SessionStatus);

        var sessionTypeId = await _sessionService.GetSessionTypeIdAsync(sessionTypeLabel);
        var sessionStatusId = await _sessionService.GetSessionStatusIdAsync(sessionStatusLabel);

        if (sessionTypeId == null)
            return BadRequest(ApiResponse<SessionResponse>.Fail($"SessionType '{sessionTypeLabel}' not found"));

        if (sessionStatusId == null)
            return BadRequest(ApiResponse<SessionResponse>.Fail($"SessionStatus '{sessionStatusLabel}' not found"));

        existing.StartDateTime = request.StartDateTime;
        existing.EndDateTime = request.EndDateTime;
        existing.Mode = request.Mode;
        existing.SessionTypeId = sessionTypeId;
        existing.CourseId = request.CourseId;
        existing.SessionStatusId = sessionStatusId;
        existing.RoomId = request.RoomId;
        existing.Description = request.Description;

        await _sessionService.UpdateSessionAsync(existing);
        var updatedFull = await _sessionService.GetSessionByIdAsync(id);

        return Ok(ApiResponse<SessionResponse>.Success(MapToResponse(updatedFull!), "Session updated successfully"));
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
            Type = SessionReferenceMapper.ToSessionTypeEnum(s.SessionTypeLabel ?? ""),
            Status = SessionReferenceMapper.ToSessionStatusEnum(s.SessionStatusLabel ?? ""),
            Room = s.RoomNumber ?? "",
            Course = s.CourseName ?? ""
        };
    }
}