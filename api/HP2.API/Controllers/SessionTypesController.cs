using HP2.Application.Contracts;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SessionTypesController : ControllerBase
{
    private readonly ISessionTypeService _sessionTypeService;

    public SessionTypesController(ISessionTypeService sessionTypeService)
    {
        _sessionTypeService = sessionTypeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _sessionTypeService.GetAllSessionTypesAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var result = await _sessionTypeService.GetSessionTypeByIdAsync(id);
        return result is null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] SessionTypeModel sessionType)
    {
        try
        {
            var created = await _sessionTypeService.CreateSessionTypeAsync(sessionType);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }
        catch (InvalidOperationException ex) { return Conflict(new { message = ex.Message }); }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] SessionTypeModel sessionType)
    {
        try
        {
            sessionType.Id = id;
            await _sessionTypeService.UpdateSessionTypeAsync(sessionType);
            return NoContent();
        }
        catch (InvalidOperationException ex) { return Conflict(new { message = ex.Message }); }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        try
        {
            await _sessionTypeService.DeleteSessionTypeAsync(id);
            return NoContent();
        }
        catch (InvalidOperationException ex) { return Conflict(new { message = ex.Message }); }
    }
}
