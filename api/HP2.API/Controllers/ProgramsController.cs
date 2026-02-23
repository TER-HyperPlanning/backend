using HP2.Application.Contracts;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProgramsController : ControllerBase
{
    private readonly IProgramService _programService;

    public ProgramsController(IProgramService programService)
    {
        _programService = programService;
    }

    [HttpPost]
    public async Task<ActionResult<ProgramModel>> Create([FromBody] ProgramModel program)
    {
        if (program == null)
            return BadRequest();

        var createdProgram = await _programService.CreateProgramAsync(program);
        return CreatedAtAction(nameof(Get), new { id = createdProgram.Id }, createdProgram);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProgramModel>> Get(string id)
    {
        var program = await _programService.GetProgramByIdAsync(id);
        if (program == null)
            return NotFound();

        return Ok(program);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProgramModel>>> GetAll()
    {
        var programs = await _programService.GetAllProgramsAsync();
        return Ok(programs);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] ProgramModel program)
    {
        if (program == null)
            return BadRequest();

        if (id != program.Id)
            return BadRequest("ID mismatch");

        var existing = await _programService.GetProgramByIdAsync(id);
        if (existing == null)
            return NotFound($"Program with ID {id} not found");

        await _programService.UpdateProgramAsync(program);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var existing = await _programService.GetProgramByIdAsync(id);
        if (existing == null)
            return NotFound($"Program with ID {id} not found");

        await _programService.DeleteProgramAsync(id);
        return NoContent();
    }
}
