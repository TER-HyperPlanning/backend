using HP2.Application.Contracts;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BuildingsController : ControllerBase
{
    private readonly IBuildingService _buildingService;

    public BuildingsController(IBuildingService buildingService)
    {
        _buildingService = buildingService;
    }

    [HttpPost]
    public async Task<ActionResult<BuildingModel>> Create([FromBody] BuildingModel building)
    {
        if (building == null)
            return BadRequest();

        var createdBuilding = await _buildingService.CreateBuildingAsync(building);
        return CreatedAtAction(nameof(Get), new { id = createdBuilding.Id }, createdBuilding);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<BuildingModel>> Get(string id)
    {
        var building = await _buildingService.GetBuildingByIdAsync(id);
        if (building == null)
            return NotFound();

        return Ok(building);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BuildingModel>>> GetAll()
    {
        var buildings = await _buildingService.GetAllBuildingsAsync();
        return Ok(buildings);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] BuildingModel building)
    {
        if (building == null)
            return BadRequest();

        if (id != building.Id)
            return BadRequest("ID mismatch");

        var existing = await _buildingService.GetBuildingByIdAsync(id);
        if (existing == null)
            return NotFound($"Building with ID {id} not found");

        await _buildingService.UpdateBuildingAsync(building);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var existing = await _buildingService.GetBuildingByIdAsync(id);
        if (existing == null)
            return NotFound($"Building with ID {id} not found");

        await _buildingService.DeleteBuildingAsync(id);
        return NoContent();
    }
}
