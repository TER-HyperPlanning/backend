using HP2.Application.Contracts;
using HP2.Application.DTOs.Building;
using HP2.Application.DTOs.Common;
using HP2.Application.Exceptions;
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
    public async Task<ActionResult<ApiResponse<BuildingResponse>>> Create([FromBody] CreateBuildingRequest request)
    {
        try
        {
            if (request == null)
                return BadRequest(ApiResponse<BuildingResponse>.Fail("Building content is required"));

            var building = new BuildingModel
            {
                Name = request.Name
            };

            var createdBuilding = await _buildingService.CreateBuildingAsync(building);
            return CreatedAtAction(nameof(Get), new { id = createdBuilding.Id },
                ApiResponse<BuildingResponse>.Success(MapToResponse(createdBuilding), "Building created successfully"));
        }
        catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
        {
            return Conflict(ApiResponse<BuildingResponse>.Fail("Building already exists, choose another name"));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<BuildingResponse>.Fail(ex.Message));
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<BuildingResponse>>> Get(string id)
    {
        try
        {
            var building = await _buildingService.GetBuildingByIdAsync(id);
            if (building == null)
                return NotFound(ApiResponse<BuildingResponse>.Fail($"Building with id {id} not found"));

            return Ok(ApiResponse<BuildingResponse>.Success(MapToResponse(building)));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<BuildingResponse>.Fail(ex.Message));
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                ApiResponse<BuildingResponse>.Fail("An internal error occurred"));
        }
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<BuildingResponse>>>> GetAll()
    {
        try
        {
            var buildings = await _buildingService.GetAllBuildingsAsync();
            var response = buildings.Select(MapToResponse);
            return Ok(ApiResponse<IEnumerable<BuildingResponse>>.Success(response));
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                ApiResponse<IEnumerable<BuildingResponse>>.Fail("An internal error occurred"));
        }
    }

    [HttpGet("deleted")]
    public async Task<ActionResult<ApiResponse<IEnumerable<DeletedBuildingResponse>>>> GetDeleted()
    {
        var buildings = await _buildingService.GetDeletedBuildingsAsync();
        var response = buildings.Select(MapToDeletedResponse);
        return Ok(ApiResponse<IEnumerable<DeletedBuildingResponse>>.Success(response));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<BuildingResponse>>> Update(string id, [FromBody] UpdateBuildingRequest request)
    {
        try
        {
            if (request == null)
                return BadRequest(ApiResponse<BuildingResponse>.Fail("Building content is required"));

            var existing = await _buildingService.GetBuildingByIdAsync(id);
            if (existing == null)
                return NotFound(ApiResponse<BuildingResponse>.Fail($"Building with id {id} not found"));

            existing.Name = request.Name;

            await _buildingService.UpdateBuildingAsync(existing);
            return Ok(ApiResponse<BuildingResponse>.Success(MapToResponse(existing), "Building updated successfully"));
        }
        catch (DbUpdateException ex) when (ex.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
        {
            return Conflict(ApiResponse<BuildingResponse>.Fail("Building already exists, choose another name"));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<BuildingResponse>.Fail(ex.Message));
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<object>>> Delete(string id)
    {
        try
        {
            var existing = await _buildingService.GetBuildingByIdAsync(id);
            if (existing == null)
                return NotFound(ApiResponse<object>.Fail($"Building with id {id} not found"));

            await _buildingService.DeleteBuildingAsync(id);
            return Ok(ApiResponse<object>.Success(id, "Building deleted successfully"));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<object>.Fail(ex.Message));
        }
        catch (DeleteConflictException ex)
        {
            return Conflict(ApiResponse<object>.Fail(ex.Message, ex.BlockingSession));
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                ApiResponse<object>.Fail("An internal error occurred"));
        }
    }

    private static DeletedBuildingResponse MapToDeletedResponse(BuildingModel building)
    {
        return new DeletedBuildingResponse
        {
            Id = building.Id,
            Name = building.Name,
            DeletedAt = building.DeletedAt
        };
    }

    private static BuildingResponse MapToResponse(BuildingModel building)
    {
        return new BuildingResponse
        {
            Id = building.Id,
            Name = building.Name,
            DeletedAt = building.DeletedAt
        };
    }
}
