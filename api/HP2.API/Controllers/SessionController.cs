using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Session;
using HP2.Application.Helpers;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

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
        {
            if (!ModelState.IsValid)
            {
                var invalidFields = ModelState
                    .Where(x => x.Value != null && x.Value.Errors.Count > 0)
                    .Select(x => x.Key.Split('.').Last())
                    .Where(x => !string.IsNullOrWhiteSpace(x)
                                && !x.Equals("request", StringComparison.OrdinalIgnoreCase)
                                && x != "$")
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .ToList();

                if (invalidFields.Any())
                    return BadRequest(ApiResponse<SessionResponse>.Fail($"Invalid field values: {string.Join(", ", invalidFields.Select(FormatFieldWithAllowedValues))}"));
            }

            return BadRequest(ApiResponse<SessionResponse>.Fail("Session payload is required"));
        }

        var missing = new List<string>();
        if (!request.StartDateTime.HasValue) missing.Add("startDateTime");
        if (!request.EndDateTime.HasValue) missing.Add("endDateTime");
        if (!request.Mode.HasValue) missing.Add("mode");
        if (!request.SessionType.HasValue) missing.Add("sessionType");
        if (string.IsNullOrWhiteSpace(request.CourseId)) missing.Add("courseId");
        if (!request.SessionStatus.HasValue) missing.Add("sessionStatus");
        if (string.IsNullOrWhiteSpace(request.RoomId)) missing.Add("roomId");

        if (missing.Any())
            return BadRequest(ApiResponse<SessionResponse>.Fail($"Missing required fields: {string.Join(", ", missing.Select(FormatFieldWithAllowedValues))}"));

        if (!await _sessionService.CourseExistsAsync(request.CourseId))
            return BadRequest(ApiResponse<SessionResponse>.Fail($"Course with ID '{request.CourseId}' not found"));

        if (!await _sessionService.RoomExistsAsync(request.RoomId))
            return BadRequest(ApiResponse<SessionResponse>.Fail($"Room with ID '{request.RoomId}' not found"));

        if (request.EndDateTime.Value <= request.StartDateTime.Value)
            return BadRequest(ApiResponse<SessionResponse>.Fail("EndDateTime must be greater than StartDateTime"));

        if (request.StartDateTime.Value.Date != request.EndDateTime.Value.Date)
            return BadRequest(ApiResponse<SessionResponse>.Fail("StartDateTime and EndDateTime must be on the same date"));

        var sessionTypeLabel = SessionReferenceMapper.ToLabel(request.SessionType.Value);
        var sessionStatusLabel = SessionReferenceMapper.ToLabel(request.SessionStatus.Value);

        var sessionTypeId = await _sessionService.GetSessionTypeIdAsync(sessionTypeLabel);
        var sessionStatusId = await _sessionService.GetSessionStatusIdAsync(sessionStatusLabel);

        if (sessionTypeId == null)
            return BadRequest(ApiResponse<SessionResponse>.Fail($"SessionType '{sessionTypeLabel}' not found"));

        if (sessionStatusId == null)
            return BadRequest(ApiResponse<SessionResponse>.Fail($"SessionStatus '{sessionStatusLabel}' not found"));

        var model = new SessionModel
        {
            StartDateTime = request.StartDateTime.Value,
            EndDateTime = request.EndDateTime.Value,
            Mode = request.Mode.Value,
            SessionTypeId = sessionTypeId,
            CourseId = request.CourseId,
            SessionStatusId = sessionStatusId,
            RoomId = request.RoomId,
            Description = request.Description
        };

        try
        {
            var created = await _sessionService.CreateSessionAsync(model);
            var createdFull = await _sessionService.GetSessionByIdAsync(created.Id);

            return CreatedAtAction(nameof(Get), new { id = created.Id },
                ApiResponse<SessionResponse>.Success(MapToResponse(createdFull!), "Session created successfully"));
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(ApiResponse<SessionResponse>.Fail(ex.Message));
        }
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
    [HttpGet("deleted")]
    public async Task<ActionResult<ApiResponse<IEnumerable<DeletedSessionResponse>>>> GetDeleted()
    {
        var sessions = await _sessionService.GetDeletedSessionsAsync();
        var response = sessions.Select(MapToDeletedResponse);
        return Ok(ApiResponse<IEnumerable<DeletedSessionResponse>>.Success(response));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<SessionResponse>>> Update(string id, [FromBody] UpdateSessionRequest request)
    {
        if (request == null)
        {
            if (!ModelState.IsValid)
            {
                var invalidFields = ModelState
                    .Where(x => x.Value != null && x.Value.Errors.Count > 0)
                    .Select(x => x.Key.Split('.').Last())
                    .Where(x => !string.IsNullOrWhiteSpace(x)
                                && !x.Equals("request", StringComparison.OrdinalIgnoreCase)
                                && x != "$")
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .ToList();

                if (invalidFields.Any())
                    return BadRequest(ApiResponse<SessionResponse>.Fail($"Invalid field values: {string.Join(", ", invalidFields.Select(FormatFieldWithAllowedValues))}"));
            }

            return BadRequest(ApiResponse<SessionResponse>.Fail("Session payload is required"));
        }

        var missing = new List<string>();
        if (!request.StartDateTime.HasValue) missing.Add("startDateTime");
        if (!request.EndDateTime.HasValue) missing.Add("endDateTime");
        if (!request.Mode.HasValue) missing.Add("mode");
        if (!request.SessionType.HasValue) missing.Add("sessionType");
        if (string.IsNullOrWhiteSpace(request.CourseId)) missing.Add("courseId");
        if (!request.SessionStatus.HasValue) missing.Add("sessionStatus");
        if (string.IsNullOrWhiteSpace(request.RoomId)) missing.Add("roomId");

        if (missing.Any())
            return BadRequest(ApiResponse<SessionResponse>.Fail($"Missing required fields: {string.Join(", ", missing.Select(FormatFieldWithAllowedValues))}"));

        if (!await _sessionService.CourseExistsAsync(request.CourseId))
            return BadRequest(ApiResponse<SessionResponse>.Fail($"Course with ID '{request.CourseId}' not found"));

        if (!await _sessionService.RoomExistsAsync(request.RoomId))
            return BadRequest(ApiResponse<SessionResponse>.Fail($"Room with ID '{request.RoomId}' not found"));

        if (request.EndDateTime.Value <= request.StartDateTime.Value)
            return BadRequest(ApiResponse<SessionResponse>.Fail("EndDateTime must be greater than StartDateTime"));

        if (request.StartDateTime.Value.Date != request.EndDateTime.Value.Date)
            return BadRequest(ApiResponse<SessionResponse>.Fail("StartDateTime and EndDateTime must be on the same date"));

        var existing = await _sessionService.GetSessionByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<SessionResponse>.Fail($"Session with ID {id} not found"));

        var sessionTypeLabel = SessionReferenceMapper.ToLabel(request.SessionType.Value);
        var sessionStatusLabel = SessionReferenceMapper.ToLabel(request.SessionStatus.Value);

        var sessionTypeId = await _sessionService.GetSessionTypeIdAsync(sessionTypeLabel);
        var sessionStatusId = await _sessionService.GetSessionStatusIdAsync(sessionStatusLabel);

        if (sessionTypeId == null)
            return BadRequest(ApiResponse<SessionResponse>.Fail($"SessionType '{sessionTypeLabel}' not found"));

        if (sessionStatusId == null)
            return BadRequest(ApiResponse<SessionResponse>.Fail($"SessionStatus '{sessionStatusLabel}' not found"));

        existing.StartDateTime = request.StartDateTime.Value;
        existing.EndDateTime = request.EndDateTime.Value;
        existing.Mode = request.Mode.Value;
        existing.SessionTypeId = sessionTypeId;
        existing.CourseId = request.CourseId;
        existing.SessionStatusId = sessionStatusId;
        existing.RoomId = request.RoomId;
        existing.Description = request.Description;

        try
        {
            await _sessionService.UpdateSessionAsync(existing);
            var updatedFull = await _sessionService.GetSessionByIdAsync(id);

            return Ok(ApiResponse<SessionResponse>.Success(MapToResponse(updatedFull!), "Session updated successfully"));
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(ApiResponse<SessionResponse>.Fail(ex.Message));
        }
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
    private static DeletedSessionResponse MapToDeletedResponse(SessionModel s)
    {
        return new DeletedSessionResponse
        {
            Id = s.Id,
            StartDateTime = s.StartDateTime,
            EndDateTime = s.EndDateTime,
            Mode = s.Mode,
            Description = s.Description,
            SessionTypeId = s.SessionTypeId,
            CourseId = s.CourseId,
            SessionStatusId = s.SessionStatusId,
            RoomId = s.RoomId,
            IsDeleted = s.IsDeleted,
            DeletedAt = s.DeletedAt
        };
    }

    private static readonly Dictionary<string, string> EnumAllowedValues = new(StringComparer.OrdinalIgnoreCase)
    {
        ["mode"] = string.Join(", ", Enum.GetNames<HP2.Domain.Enums.SessionMode>()),
        ["sessionType"] = string.Join(", ", Enum.GetNames<HP2.Domain.Enums.SessionTypeEnum>()),
        ["sessionStatus"] = string.Join(", ", Enum.GetNames<HP2.Domain.Enums.SessionStatusEnum>())
    };

    private static string FormatFieldWithAllowedValues(string field)
    {
        return EnumAllowedValues.TryGetValue(field, out var allowedValues)
            ? $"{field}( {allowedValues} )"
            : field;
    }

}