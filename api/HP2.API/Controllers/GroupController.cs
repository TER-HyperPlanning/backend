using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Group;
using HP2.Application.DTOs.Student;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GroupsController : ControllerBase
{
    private readonly IGroupService _groupService;
    private readonly IStudentService _studentService;

    public GroupsController(IGroupService groupService, IStudentService studentService)
    {
        _groupService = groupService;
        _studentService = studentService;
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
    public async Task<ActionResult<ApiResponse<GroupWithStudentsResponse>>> Get(string id)
    {
        var group = await _groupService.GetGroupByIdAsync(id);

        if (group == null)
            return NotFound(ApiResponse<GroupWithStudentsResponse>.Fail($"Group with ID {id} not found"));

        var students = (await _studentService.GetStudentsByGroupIdAsync(id)).ToList();
        var response = new GroupWithStudentsResponse
        {
            Id = group.Id,
            Name = group.Name,
            AcademicYear = group.AcademicYear,
            TrackId = group.TrackId,
            StudentCount = students.Count,
            Students = students.Select(MapToStudentResponse).ToList()
        };

        return Ok(ApiResponse<GroupWithStudentsResponse>.Success(response));
    }

    private static StudentResponse MapToStudentResponse(StudentModel student)
    {
        return new StudentResponse
        {
            Id = student.Id,
            Email = student.Email,
            FirstName = student.FirstName,
            LastName = student.LastName,
            Phone = student.Phone,
            GroupId = student.GroupId,
            Role = student.Role,
            CreatedAt = student.CreatedAt,
            UpdatedAt = student.UpdatedAt,
            DeletedAt = student.DeletedAt,
        };
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

    // GET: api/groups/track/{trackId}
    [HttpGet("track/{trackId}")]
    public async Task<ActionResult<ApiResponse<IEnumerable<GroupModel>>>> GetByTrackId(string trackId)
    {
        try
        {
            var groups = await _groupService.GetGroupsByTrackIdAsync(trackId);
            return Ok(ApiResponse<IEnumerable<GroupModel>>.Success(groups, $"Groups for track ID {trackId} retrieved successfully"));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<IEnumerable<GroupModel>>.Fail(ex.Message));
        }
    }

}