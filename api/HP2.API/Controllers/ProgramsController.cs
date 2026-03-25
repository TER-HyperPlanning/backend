using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Program;
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
    public async Task<ActionResult<ApiResponse<ProgramModel>>> Create([FromBody] CreateProgramRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<ProgramModel>.Fail("Program payload is required"));

        var program = new ProgramModel
        {
            Name = request.Name,
            Field = request.Field
        };

        var createdProgram = await _programService.CreateProgramAsync(program);
        return CreatedAtAction(nameof(Get), new { id = createdProgram.Id },
            ApiResponse<ProgramModel>.Success(createdProgram, "Program created successfully"));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<ProgramModel>>> Get(string id)
    {
        var program = await _programService.GetProgramByIdAsync(id);
        if (program == null)
            return NotFound(ApiResponse<ProgramModel>.Fail($"Program with ID {id} not found"));

        return Ok(ApiResponse<ProgramModel>.Success(program));
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<ProgramModel>>>> GetAll()
    {
        var programs = await _programService.GetAllProgramsAsync();
        return Ok(ApiResponse<IEnumerable<ProgramModel>>.Success(programs));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<ProgramModel>>> Update(string id, [FromBody] UpdateProgramRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<ProgramModel>.Fail("Program payload is required"));

        var existing = await _programService.GetProgramByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<ProgramModel>.Fail($"Program with ID {id} not found"));

        existing.Name = request.Name;
        existing.Field = request.Field;

        await _programService.UpdateProgramAsync(existing);
        return Ok(ApiResponse<ProgramModel>.Success(existing, "Program updated successfully"));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        var existing = await _programService.GetProgramByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<string>.Fail($"Program with ID {id} not found"));

        await _programService.DeleteProgramAsync(id);
        return Ok(ApiResponse<string>.Success(id, "Program deleted successfully"));
    }
}
