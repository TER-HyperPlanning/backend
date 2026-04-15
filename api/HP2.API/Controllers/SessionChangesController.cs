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
            return Ok(ApiResponse<IEnumerable<SessionChangeListResponse>>.Success(data, "Demandes de modification récupérées avec succès."));
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
                return NotFound(ApiResponse<SessionChangeDetailsResponse>.Fail("Demande de modification introuvable."));

            return Ok(ApiResponse<SessionChangeDetailsResponse>.Success(item, "Demande de modification récupérée avec succès."));
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
            return Ok(ApiResponse<string>.Success(id, "Proposition de rattrapage approuvée avec succès."));
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
            return Ok(ApiResponse<string>.Success(id, "Demande de modification refusée avec succès."));
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

            return Ok(ApiResponse<string>.Success(id, "Contre-proposition soumise avec succès."));
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

    [HttpGet("{sessionId}/available-rooms")]
    public async Task<ActionResult<ApiResponse<IEnumerable<AvailableRoomResponse>>>> GetAvailableRooms(string sessionId)
    {
        try
        {
            var rooms = await _sessionChangeService.GetAvailableRoomsAsync(sessionId);
            return Ok(ApiResponse<IEnumerable<AvailableRoomResponse>>.Success(rooms, "Salles disponibles récupérées avec succès."));
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ApiResponse<IEnumerable<AvailableRoomResponse>>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<IEnumerable<AvailableRoomResponse>>.Fail($"Erreur serveur : {ex.Message}"));
        }
    }

    [HttpGet("{recoveryChangeId}/available-slots")]
    public async Task<ActionResult<ApiResponse<IEnumerable<AvailableSlotResponse>>>> GetAvailableSlots(
        string recoveryChangeId,
        [FromQuery] DateTime from,
        [FromQuery] DateTime to)
    {
        try
        {
            var slots = await _sessionChangeService.GetAvailableSlotsAsync(recoveryChangeId, from, to);
            return Ok(ApiResponse<IEnumerable<AvailableSlotResponse>>.Success(slots, "Créneaux disponibles récupérés avec succès."));
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ApiResponse<IEnumerable<AvailableSlotResponse>>.Fail(ex.Message));
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ApiResponse<IEnumerable<AvailableSlotResponse>>.Fail(ex.Message));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<IEnumerable<AvailableSlotResponse>>.Fail($"Erreur serveur : {ex.Message}"));
        }
    }
}
