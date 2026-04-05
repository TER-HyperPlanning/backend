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

            var result = data.Select(x => new SessionChangeListResponse
            {
                Id = x.Id,
                TeacherId = x.TeacherId,
                TeacherName = x.TeacherName ?? string.Empty,
                TeacherEmail = x.TeacherEmail ?? string.Empty,
                SessionId = x.SessionId,
                CourseName = x.CourseName ?? string.Empty,
                SessionDate = x.SessionDate ?? default,
                SessionStartTime = x.SessionStartTime ?? default,
                SessionEndTime = x.SessionEndTime ?? default,
                CurrentRoomNumber = x.CurrentRoomNumber ?? string.Empty,
                CurrentBuildingName = x.CurrentBuildingName ?? string.Empty,
                ChangeStatusId = x.ChangeStatusId,
                ChangeStatusLabel = x.ChangeStatusLabel ?? string.Empty,
                ChangeType = x.ChangeType.ToString(),
                Reason = x.Reason,
                RequestDate = x.Date
            });

            return Ok(ApiResponse<IEnumerable<SessionChangeListResponse>>.Success(result, "Liste des demandes récupérée avec succès."));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<IEnumerable<SessionChangeListResponse>>.Fail($"Erreur serveur : {ex.Message}"));
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<SessionChangeDetailsResponse>>> GetById(string id)
    {
        try
        {
            var item = await _sessionChangeService.GetByIdAsync(id);

            if (item == null)
                return NotFound(ApiResponse<SessionChangeDetailsResponse>.Fail("Demande introuvable."));

            var result = new SessionChangeDetailsResponse
            {
                Id = item.Id,
                TeacherId = item.TeacherId,
                TeacherName = item.TeacherName ?? string.Empty,
                TeacherEmail = item.TeacherEmail ?? string.Empty,
                SessionId = item.SessionId,
                CourseName = item.CourseName ?? string.Empty,
                SessionDate = item.SessionDate ?? default,
                SessionStartTime = item.SessionStartTime ?? default,
                SessionEndTime = item.SessionEndTime ?? default,
                CurrentRoomId = item.CurrentRoomId ?? string.Empty,
                CurrentRoomNumber = item.CurrentRoomNumber ?? string.Empty,
                CurrentBuildingName = item.CurrentBuildingName ?? string.Empty,
                ChangeStatusId = item.ChangeStatusId,
                ChangeStatusLabel = item.ChangeStatusLabel ?? string.Empty,
                ChangeType = item.ChangeType.ToString(),
                Reason = item.Reason,
                RequestDate = item.Date,
                ApprovedRoomId = item.ApprovedRoomId,
                ProposedDate = item.ProposedDate,
                ProposedStartTime = item.ProposedStartTime,
                ProposedEndTime = item.ProposedEndTime,
                ProposedRoomId = item.ProposedRoomId,
                CounterProposalDate = item.CounterProposalDate,
                CounterProposalStartTime = item.CounterProposalStartTime,
                CounterProposalEndTime = item.CounterProposalEndTime,
                CounterProposalRoomId = item.CounterProposalRoomId,
                RejectionReason = item.RejectionReason
            };

            return Ok(ApiResponse<SessionChangeDetailsResponse>.Success(result, "Détail de la demande récupéré avec succès."));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<SessionChangeDetailsResponse>.Fail($"Erreur serveur : {ex.Message}"));
        }
    }

    [HttpPost("{id}/approve-room")]
    public async Task<ActionResult<ApiResponse<string>>> ApproveRoomChange(string id, [FromBody] ApproveRoomChangeRequest request)
    {
        try
        {
            await _sessionChangeService.ApproveRoomChangeAsync(id, request.RoomId);
            return Ok(ApiResponse<string>.Success(id, "Changement de salle approuvé avec succès."));
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
            return StatusCode(500, ApiResponse<string>.Fail($"Erreur serveur : {ex.Message}"));
        }
    }

    [HttpPost("{id}/approve-recovery")]
    public async Task<ActionResult<ApiResponse<string>>> ApproveRecovery(string id)
    {
        try
        {
            await _sessionChangeService.ApproveRecoveryAsync(id);
            return Ok(ApiResponse<string>.Success(id, "Demande de récupération approuvée avec succès."));
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
            return StatusCode(500, ApiResponse<string>.Fail($"Erreur serveur : {ex.Message}"));
        }
    }

    [HttpPost("{id}/reject")]
    public async Task<ActionResult<ApiResponse<string>>> Reject(string id, [FromBody] RejectSessionChangeRequest request)
    {
        try
        {
            await _sessionChangeService.RejectAsync(id, request.RejectionReason);
            return Ok(ApiResponse<string>.Success(id, "Demande refusée avec succès."));
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
            return StatusCode(500, ApiResponse<string>.Fail($"Erreur serveur : {ex.Message}"));
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

            return Ok(ApiResponse<string>.Success(id, "Contre-proposition enregistrée avec succès."));
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
            return StatusCode(500, ApiResponse<string>.Fail($"Erreur serveur : {ex.Message}"));
        }
    }
}