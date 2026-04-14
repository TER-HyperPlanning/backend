using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Program;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<ProgramModel>>> Create([FromBody] CreateProgramRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<ProgramModel>.Fail("Program payload is required"));

        if (!ModelState.IsValid)
        {
            var missing = ModelState.Where(kv => kv.Value?.Errors.Count > 0)
                .Select(kv => kv.Key.Split('.').Last())
                .ToList();
            return BadRequest(ApiResponse<string>.Fail($"Missing required fields: {string.Join(", ", missing)}"));
        }

        var normalizedName = request.Name!.Trim();
        var normalizedField = request.Field!.Trim();
        var existingPrograms = await _programService.GetAllProgramsAsync();

        if (existingPrograms.Any(p => p.Name.Equals(normalizedName, StringComparison.OrdinalIgnoreCase)))
            return Conflict(ApiResponse<string>.Fail("A program with the same name already exists"));

        if (existingPrograms.Any(p => p.Field.Equals(normalizedField, StringComparison.OrdinalIgnoreCase)))
            return Conflict(ApiResponse<string>.Fail("A program with the same field already exists"));

        if (existingPrograms.Any(p =>
                p.Name.Equals(normalizedName, StringComparison.OrdinalIgnoreCase) &&
                p.Field.Equals(normalizedField, StringComparison.OrdinalIgnoreCase)))
            return Conflict(ApiResponse<string>.Fail("A program with the same name and field already exists"));

        var program = new ProgramModel
        {
            Name = normalizedName,
            Field = normalizedField
        };

        var createdProgram = await _programService.CreateProgramAsync(program);
        return CreatedAtAction(nameof(Get), new { id = createdProgram.Id },
            ApiResponse<ProgramModel>.Success(createdProgram, "Program created successfully"));
    }

    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<ApiResponse<ProgramModel>>> Get(string id)
    {
        var program = await _programService.GetProgramByIdAsync(id);
        if (program == null)
            return NotFound(ApiResponse<ProgramModel>.Fail($"Program with ID {id} not found"));

        return Ok(ApiResponse<ProgramModel>.Success(program));
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<ApiResponse<IEnumerable<ProgramModel>>>> GetAll()
    {
        var programs = await _programService.GetAllProgramsAsync();
        return Ok(ApiResponse<IEnumerable<ProgramModel>>.Success(programs));
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<ProgramModel>>> Update(string id, [FromBody] UpdateProgramRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<ProgramModel>.Fail("Program payload is required"));

        if (!ModelState.IsValid)
        {
            var missing = ModelState.Where(kv => kv.Value?.Errors.Count > 0)
                .Select(kv => kv.Key.Split('.').Last())
                .ToList();
            return BadRequest(ApiResponse<string>.Fail($"Missing required fields: {string.Join(", ", missing)}"));
        }

        var normalizedName = request.Name!.Trim();
        var normalizedField = request.Field!.Trim();
        var existingPrograms = await _programService.GetAllProgramsAsync();

        if (existingPrograms.Any(p => p.Id != id && p.Name.Equals(normalizedName, StringComparison.OrdinalIgnoreCase)))
            return Conflict(ApiResponse<string>.Fail("A program with the same name already exists"));

        if (existingPrograms.Any(p => p.Id != id && p.Field.Equals(normalizedField, StringComparison.OrdinalIgnoreCase)))
            return Conflict(ApiResponse<string>.Fail("A program with the same field already exists"));

        if (existingPrograms.Any(p =>
                p.Id != id &&
                p.Name.Equals(normalizedName, StringComparison.OrdinalIgnoreCase) &&
                p.Field.Equals(normalizedField, StringComparison.OrdinalIgnoreCase)))
            return Conflict(ApiResponse<string>.Fail("A program with the same name and field already exists"));

        var existing = await _programService.GetProgramByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<ProgramModel>.Fail($"Program with ID {id} not found"));

        existing.Name = normalizedName;
        existing.Field = normalizedField;

        await _programService.UpdateProgramAsync(existing);
        return Ok(ApiResponse<ProgramModel>.Success(existing, "Program updated successfully"));
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        var existing = await _programService.GetProgramByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<string>.Fail($"Program with ID {id} not found"));

        await _programService.DeleteProgramAsync(id);
        return Ok(ApiResponse<string>.Success(id, "Program deleted successfully"));
    }
}
