using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Group;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Authorization;
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
        if (request == null)
            return BadRequest(ApiResponse<GroupModel>.Fail("Group data is required"));
        var missing = new List<string>();
        if (string.IsNullOrWhiteSpace(request.Name)) missing.Add("name");
        if (string.IsNullOrWhiteSpace(request.AcademicYear)) missing.Add("academicYear");
        if (string.IsNullOrWhiteSpace(request.TrackId)) missing.Add("trackId");
        if (missing.Any())
            return BadRequest(ApiResponse<GroupModel>.Fail($"Missing required fields: {string.Join(", ", missing)}"));

        var group = new GroupModel { Name = request.Name, AcademicYear = request.AcademicYear, TrackId = request.TrackId };
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
    [AllowAnonymous]
    public async Task<ActionResult<ApiResponse<GroupModel>>> Get(string id)
    {
        var group = await _groupService.GetGroupByIdAsync(id);

        if (group == null)
            return NotFound(ApiResponse<GroupModel>.Fail($"Group with ID {id} not found"));

        return Ok(ApiResponse<GroupModel>.Success(group));
    }

    // GET: api/groups
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<ApiResponse<IEnumerable<GroupModel>>>> GetAll()
    {
        var groups = await _groupService.GetAllGroupsAsync();
        return Ok(ApiResponse<IEnumerable<GroupModel>>.Success(groups));
    }

    // PUT: api/groups/{id}
    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<object>>> Update(string id, [FromBody] UpdateGroupRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<object>.Fail("Group data is required"));

        var existing = await _groupService.GetGroupByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<object>.Fail($"Group with ID {id} not found"));
        var missing = new List<string>();
        if (string.IsNullOrWhiteSpace(request.Name)) missing.Add("name");
        if (string.IsNullOrWhiteSpace(request.AcademicYear)) missing.Add("academicYear");
        if (string.IsNullOrWhiteSpace(request.TrackId)) missing.Add("trackId");
        if (missing.Any())
            return BadRequest(ApiResponse<object>.Fail($"Missing required fields: {string.Join(", ", missing)}"));

        existing.Name = request.Name;
        existing.AcademicYear = request.AcademicYear;
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