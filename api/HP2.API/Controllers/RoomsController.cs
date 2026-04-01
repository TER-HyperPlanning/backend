using HP2.Application.Contracts;
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
        return Ok(rooms);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var room = await _roomService.GetByIdAsync(id);
        if (room == null) return NotFound();
        return Ok(room);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] RoomModel room)
    {
        await _roomService.CreateAsync(room);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] RoomModel room)
    {
        await _roomService.UpdateAsync(room);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _roomService.DeleteAsync(id);
        return Ok();
    }
}