using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Domain.Models;
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
    public async Task<IActionResult> GetAll()
    {
        var rooms = await _roomService.GetAllAsync();

        return Ok(ApiResponse<List<RoomModel>>.Success(rooms, "Rooms retrieved successfully"));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var room = await _roomService.GetByIdAsync(id);

        if (room == null)
            return NotFound(ApiResponse<string>.Fail("Room not found"));

        return Ok(ApiResponse<RoomModel>.Success(room, "Room retrieved successfully"));
    }

    [HttpGet("number/{roomNumber}")]
    public async Task<IActionResult> GetByRoomNumber(string roomNumber)
    {
        var room = await _roomService.GetByRoomNumberAsync(roomNumber);

        if (room == null)
            return NotFound(ApiResponse<string>.Fail("Room not found"));

        return Ok(ApiResponse<RoomModel>.Success(room,"Room retrieved successfully"));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] RoomModel room)
    {
        if (room == null)
            return BadRequest(ApiResponse<string>.Fail("Invalid data"));

        await _roomService.CreateAsync(room);

        return Ok(ApiResponse<string>.Success("Created successfully"));
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] RoomModel room)
    {
        if (room == null)
            return BadRequest(ApiResponse<string>.Fail("Invalid data"));

        await _roomService.UpdateAsync(room);

        return Ok(ApiResponse<string>.Success("Updated successfully"));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _roomService.DeleteAsync(id);

        return Ok(ApiResponse<string>.Success("Deleted successfully"));
    }
}