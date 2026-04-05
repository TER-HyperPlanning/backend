using HP2.Application.Contracts;
using HP2.Application.DTOs.Building;
using HP2.Application.DTOs.Common;
using HP2.Domain.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public async Task<ActionResult<ApiResponse<BuildingModel>>> Create([FromBody] CreateBuildingRequest request)
    {
        try
        {
            if (request == null)
                return BadRequest(ApiResponse<BuildingModel>.Fail("Building content is required"));

            var building = new BuildingModel
            {
                Name = request.Name
            };

            var createdBuilding = await _buildingService.CreateBuildingAsync(building);
            return CreatedAtAction(nameof(Get), new { id = createdBuilding.Id },
                ApiResponse<BuildingModel>.Success(createdBuilding, "Building created successfully"));
        }
        catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
        {
            return Conflict(ApiResponse<BuildingModel>.Fail("Building already exists, choose another name"));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<BuildingModel>.Fail(ex.Message));
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<BuildingModel>>> Get(string id)
    {
        try
        {
            var building = await _buildingService.GetBuildingByIdAsync(id);
            if (building == null)
                return NotFound(ApiResponse<BuildingModel>.Fail($"Building with id {id} not found"));

            return Ok(ApiResponse<BuildingModel>.Success(building));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<BuildingModel>.Fail(ex.Message));
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                ApiResponse<BuildingModel>.Fail("An internal error occurred"));
        }
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<BuildingModel>>>> GetAll()
    {
        try
        {
            var buildings = await _buildingService.GetAllBuildingsAsync();
            return Ok(ApiResponse<IEnumerable<BuildingModel>>.Success(buildings));
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                ApiResponse<IEnumerable<BuildingModel>>.Fail("An internal error occurred"));
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<BuildingModel>>> Update(string id, [FromBody] UpdateBuildingRequest request)
    {
        try
        {
            if (request == null)
                return BadRequest(ApiResponse<BuildingModel>.Fail("Building content is required"));

            var existing = await _buildingService.GetBuildingByIdAsync(id);
            if (existing == null)
                return NotFound(ApiResponse<BuildingModel>.Fail($"Building with id {id} not found"));

            existing.Name = request.Name;

            await _buildingService.UpdateBuildingAsync(existing);
            return Ok(ApiResponse<BuildingModel>.Success(existing, "Building updated successfully"));
        }
        catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
        {
            return Conflict(ApiResponse<BuildingModel>.Fail("Building already exists, choose another name"));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<BuildingModel>.Fail(ex.Message));
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        try
        {
            var existing = await _buildingService.GetBuildingByIdAsync(id);
            if (existing == null)
                return NotFound(ApiResponse<BuildingModel>.Fail($"Building with id {id} not found"));

            await _buildingService.DeleteBuildingAsync(id);
            return Ok(ApiResponse<string>.Success(id, "Building deleted successfully"));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<string>.Fail(ex.Message));
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                ApiResponse<string>.Fail("An internal error occurred"));
        }
    }
}
