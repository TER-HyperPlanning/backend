using HP2.Application.Contracts;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AvailabilitiesController : ControllerBase
{
    private readonly IAvailabilityService _service;

    public AvailabilitiesController(IAvailabilityService service)
    {
        _service = service;
    }

    [HttpGet("teacher/{teacherId}")]
    public async Task<IActionResult> GetByTeacher(string teacherId)
    {
        var data = await _service.GetByTeacherAsync(teacherId);
        return Ok(data);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AvailabilityModel model)
    {
        var result = await _service.CreateAsync(model);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] AvailabilityModel model)
    {
        await _service.UpdateAsync(id, model);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _service.DeleteAsync(id);
        return Ok();
    }
}