using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Room;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoomsController : ControllerBase
{
    private readonly IRoomService _roomService;

    public RoomsController(IRoomService roomService)
    {
        _roomService = roomService;
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<RoomResponse>>>> GetAll()
    {
        try
        {
            var result = await _roomService.GetAllAsync();
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<IEnumerable<RoomResponse>>.Fail($"Erreur serveur : {ex.Message}"));
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<RoomResponse>>> Get(string id)
    {
        try
        {
            var result = await _roomService.GetByIdAsync(id);
            if (result.Status == "failed")
                return NotFound(result);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<RoomResponse>.Fail($"Erreur serveur : {ex.Message}"));
        }
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] CreateRoomRequest request)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Where(x => x.Value?.Errors.Count > 0)
                    .ToDictionary(
                        k => k.Key,
                        v => v.Value!.Errors.Select(e => e.ErrorMessage).ToArray()
                    );
                return BadRequest(new { status = "failed", errors });
            }

            var result = await _roomService.CreateAsync(request);
            if (result.Status == "failed")
                return BadRequest(result);

            return CreatedAtAction(nameof(Get), new { id = result.Result!.RoomId }, result);
        }
        catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
        {
            var inner = ex.InnerException?.Message ?? ex.Message;

            if (inner.Contains("FK_Room_Building"))
                return BadRequest(ApiResponse<RoomResponse>.Fail("Le bâtiment spécifié n'existe pas."));

            if (inner.Contains("RoomType") || inner.Contains("room_type_id"))
                return BadRequest(ApiResponse<RoomResponse>.Fail("Le type de salle spécifié n'existe pas."));

            if (inner.Contains("UNIQUE") || inner.Contains("UQ_") || inner.Contains("unique"))
                return BadRequest(ApiResponse<RoomResponse>.Fail("Ce numéro de salle existe déjà."));

            return StatusCode(500, ApiResponse<RoomResponse>.Fail($"Erreur base de données : {inner}"));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<RoomResponse>.Fail($"Erreur serveur : {ex.Message}"));
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(string id, [FromBody] UpdateRoomRequest request)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Where(x => x.Value?.Errors.Count > 0)
                    .ToDictionary(
                        k => k.Key,
                        v => v.Value!.Errors.Select(e => e.ErrorMessage).ToArray()
                    );
                return BadRequest(new { status = "failed", errors });
            }

            var result = await _roomService.UpdateAsync(id, request);
            if (result.Status == "failed")
                return result.Message.Contains("introuvable") ? NotFound(result) : BadRequest(result);

            return Ok(result);
        }
        catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
        {
            var inner = ex.InnerException?.Message ?? ex.Message;

            if (inner.Contains("FK_Room_Building"))
                return BadRequest(ApiResponse<RoomResponse>.Fail("Le bâtiment spécifié n'existe pas."));

            if (inner.Contains("RoomType") || inner.Contains("room_type_id"))
                return BadRequest(ApiResponse<RoomResponse>.Fail("Le type de salle spécifié n'existe pas."));

            if (inner.Contains("UNIQUE") || inner.Contains("UQ_") || inner.Contains("unique"))
                return BadRequest(ApiResponse<RoomResponse>.Fail("Ce numéro de salle existe déjà."));

            return StatusCode(500, ApiResponse<RoomResponse>.Fail($"Erreur base de données : {inner}"));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<RoomResponse>.Fail($"Erreur serveur : {ex.Message}"));
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        try
        {
            var result = await _roomService.DeleteAsync(id);
            if (result.Status == "failed")
                return NotFound(result);
            return Ok(result);
        }
        catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
        {
            var inner = ex.InnerException?.Message ?? ex.Message;

            if (inner.Contains("FK_") || inner.Contains("REFERENCE"))
                return BadRequest(ApiResponse<string>.Fail("Impossible de supprimer cette salle car elle est utilisée par des sessions."));

            return StatusCode(500, ApiResponse<string>.Fail($"Erreur base de données : {inner}"));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ApiResponse<string>.Fail($"Erreur serveur : {ex.Message}"));
        }
    }
}
