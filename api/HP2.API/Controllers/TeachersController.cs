using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Teacher;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using HP2.Domain.Enums;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeachersController : ControllerBase
{
    private readonly ITeacherService _teacherService;

    public TeachersController(ITeacherService teacherService)
    {
        _teacherService = teacherService;
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<TeacherResponse>>> Create([FromBody] CreateTeacherRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ApiResponse<TeacherResponse>.Fail("All fields are required"));

        var teacher = new TeacherModel
        {
            Email = request.Email,
            Password = request.Password,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Phone = request.Phone,
            Matricule = request.Matricule,
            Title = request.Title,
        };

        var created = await _teacherService.CreateTeacherAsync(teacher);
        var response = ToResponse(created);
        return CreatedAtAction(nameof(Get), new { id = response.Id },
            ApiResponse<TeacherResponse>.Success(response, "Teacher created successfully"));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<TeacherResponse>>> Get(string id)
    {
        var teacher = await _teacherService.GetTeacherByIdAsync(id);
        if (teacher == null)
            return NotFound(ApiResponse<TeacherResponse>.Fail($"Teacher with ID {id} not found"));

        return Ok(ApiResponse<TeacherResponse>.Success(ToResponse(teacher)));
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<TeacherResponse>>>> GetAll()
    {
        var teachers = await _teacherService.GetAllTeachersAsync();
        return Ok(ApiResponse<IEnumerable<TeacherResponse>>.Success(teachers.Select(ToResponse)));
    }

    [HttpGet("deleted")]
    public async Task<ActionResult<ApiResponse<IEnumerable<DeletedTeacherResponse>>>> GetDeleted()
    {
        var teachers = await _teacherService.GetDeletedTeachersAsync();
        return Ok(ApiResponse<IEnumerable<DeletedTeacherResponse>>.Success(teachers.Select(ToDeletedResponse)));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<TeacherResponse>>> Update(string id, [FromBody] UpdateTeacherRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ApiResponse<TeacherResponse>.Fail("All fields are required"));

        var existing = await _teacherService.GetTeacherByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<TeacherResponse>.Fail($"Teacher with ID {id} not found"));

        existing.Email = request.Email;
        existing.FirstName = request.FirstName;
        existing.LastName = request.LastName;
        existing.Phone = request.Phone;
        existing.Matricule = request.Matricule;
        existing.Title = request.Title;

        await _teacherService.UpdateTeacherAsync(existing);
        return Ok(ApiResponse<TeacherResponse>.Success(ToResponse(existing), "Teacher updated successfully"));
    }

    [HttpDelete("{id}")]
public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
{
    var existing = await _teacherService.GetTeacherByIdAsync(id);
    if (existing == null)
        return NotFound(ApiResponse<string>.Fail($"Teacher with ID {id} not found"));

    var hasAvailabilities = await _teacherService.HasAvailabilitiesAsync(id);
    if (hasAvailabilities)
        return BadRequest(ApiResponse<string>.Fail("Cannot delete a teacher who has availabilities assigned"));

    await _teacherService.DeleteTeacherAsync(id);
    return Ok(ApiResponse<string>.Success(id, "Teacher deleted successfully"));
}

    private static TeacherResponse ToResponse(TeacherModel m) => new()
    {
        Id = m.Id,
        Email = m.Email,
        FirstName = m.FirstName,
        LastName = m.LastName,
        Phone = m.Phone,
        Matricule = m.Matricule,
        Title = m.Title,
        Role = m.Role,
        CreatedAt = m.CreatedAt,
        UpdatedAt = m.UpdatedAt,
    };

    private static DeletedTeacherResponse ToDeletedResponse(TeacherModel m) => new()
    {
        Id = m.Id,
        Email = m.Email,
        FirstName = m.FirstName,
        LastName = m.LastName,
        Phone = m.Phone,
        Matricule = m.Matricule,
        Title = m.Title,
        Role = m.Role,
        CreatedAt = m.CreatedAt,
        UpdatedAt = m.UpdatedAt,
        DeletedAt = m.DeletedAt,
    };

    [HttpGet("search")]
public async Task<ActionResult<ApiResponse<IEnumerable<TeacherResponse>>>> Search([FromQuery] string query)
{
    if (string.IsNullOrWhiteSpace(query))
        return BadRequest(ApiResponse<IEnumerable<TeacherResponse>>.Fail("Query parameter is required"));

    var teachers = await _teacherService.SearchAsync(query);
    return Ok(ApiResponse<IEnumerable<TeacherResponse>>.Success(teachers.Select(ToResponse)));
}

[HttpGet("filter")]
public async Task<ActionResult<ApiResponse<IEnumerable<TeacherResponse>>>> Filter([FromQuery] TeacherTitle title)
{
    var teachers = await _teacherService.FilterByTitleAsync(title);
    return Ok(ApiResponse<IEnumerable<TeacherResponse>>.Success(teachers.Select(ToResponse)));
}
}