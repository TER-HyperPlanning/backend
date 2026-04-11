using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Group;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GroupsController : ControllerBase
{
    private readonly IGroupService _groupService;

    public GroupsController(IGroupService groupService)
    {
        _groupService = groupService;
    }

    // POST: api/groups
    [HttpPost]
    public async Task<ActionResult<ApiResponse<GroupModel>>> Create([FromBody] CreateGroupRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ApiResponse<GroupModel>.Fail("Invalid data"));

        var group = new GroupModel
        {
            Name = request.Name,
            AcademicYear = request.AcademicYear,
            Place = request.Place,
            TrackId = request.TrackId
        };

        try
        {
            var createdGroup = await _groupService.CreateGroupAsync(group);

            return CreatedAtAction(
                nameof(Get),
                new { id = createdGroup.Id },
                ApiResponse<GroupModel>.Success(createdGroup, "Group created successfully")
            );
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<GroupModel>.Fail(ex.Message));
        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<GroupModel>.Fail("Internal server error"));
        }
    }

    // GET: api/groups/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GroupModel>>> Get(string id)
    {
        var group = await _groupService.GetGroupByIdAsync(id);

        if (group == null)
            return NotFound(ApiResponse<GroupModel>.Fail($"Group with ID {id} not found"));

        return Ok(ApiResponse<GroupModel>.Success(group));
    }

    // GET: api/groups
    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<GroupModel>>>> GetAll()
    {
        var groups = await _groupService.GetAllGroupsAsync();
        return Ok(ApiResponse<IEnumerable<GroupModel>>.Success(groups));
    }

    // PUT: api/groups/{id}
    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<object>>> Update(string id, [FromBody] UpdateGroupRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ApiResponse<object>.Fail("Invalid data"));

        var existing = await _groupService.GetGroupByIdAsync(id);

        if (existing == null)
            return NotFound(ApiResponse<object>.Fail($"Group with ID {id} not found"));

        existing.Name = request.Name;
        existing.AcademicYear = request.AcademicYear;
        existing.Place = request.Place;
        existing.TrackId = request.TrackId;

        try
        {
            await _groupService.UpdateGroupAsync(existing);
            return Ok(ApiResponse<object>.Success(null!, "Group updated successfully"));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<object>.Fail(ex.Message));
        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<object>.Fail("Internal server error"));
        }
    }

    // DELETE: api/groups/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var existing = await _groupService.GetGroupByIdAsync(id);

        if (existing == null)
            return NotFound(ApiResponse<object>.Fail($"Group with ID {id} not found"));

        await _groupService.DeleteGroupAsync(id);
        return NoContent();
    }
}