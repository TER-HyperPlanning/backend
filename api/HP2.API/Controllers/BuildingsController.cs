using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
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
    public async Task<ActionResult<ApiResponse<BuildingModel>>> Create([FromBody] BuildingModel building)
    {
        if (building == null)
            return BadRequest(ApiResponse<BuildingModel>.Fail("Building payload is required"));

        var createdBuilding = await _buildingService.CreateBuildingAsync(building);
        return CreatedAtAction(nameof(Get), new { id = createdBuilding.Id },
            ApiResponse<BuildingModel>.Success(createdBuilding, "Building created successfully"));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<BuildingModel>>> Get(string id)
    {
        var building = await _buildingService.GetBuildingByIdAsync(id);
        if (building == null)
            return NotFound(ApiResponse<BuildingModel>.Fail($"Building with ID {id} not found"));

        return Ok(ApiResponse<BuildingModel>.Success(building));
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<BuildingModel>>>> GetAll()
    {
        var buildings = await _buildingService.GetAllBuildingsAsync();
        return Ok(ApiResponse<IEnumerable<BuildingModel>>.Success(buildings));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<BuildingModel>>> Update(string id, [FromBody] BuildingModel building)
    {
        if (building == null)
            return BadRequest(ApiResponse<BuildingModel>.Fail("Building payload is required"));

        if (id != building.Id)
            return BadRequest(ApiResponse<BuildingModel>.Fail("ID mismatch"));

        var existing = await _buildingService.GetBuildingByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<BuildingModel>.Fail($"Building with ID {id} not found"));

        await _buildingService.UpdateBuildingAsync(building);
        return Ok(ApiResponse<BuildingModel>.Success(building, "Building updated successfully"));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        var existing = await _buildingService.GetBuildingByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<string>.Fail($"Building with ID {id} not found"));

        await _buildingService.DeleteBuildingAsync(id);
        return Ok(ApiResponse<string>.Success(id, "Building deleted successfully"));
    }
}
