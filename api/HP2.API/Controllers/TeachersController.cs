using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Teacher;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

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
    public async Task<ActionResult<ApiResponse<TeacherModel>>> Create([FromBody] CreateTeacherRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<TeacherModel>.Fail("Teacher payload is required"));

        var teacher = new TeacherModel
        {
            Email = request.Email,
            Password = request.Password,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Phone = request.Phone,
            Matricule = request.Matricule,
            TitleId = request.TitleId,
        };

        var createdTeacher = await _teacherService.CreateTeacherAsync(teacher);
        return CreatedAtAction(nameof(Get), new { id = createdTeacher.Id },
            ApiResponse<TeacherModel>.Success(createdTeacher, "Teacher created successfully"));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<TeacherModel>>> Get(string id)
    {
        var teacher = await _teacherService.GetTeacherByIdAsync(id);
        if (teacher == null)
            return NotFound(ApiResponse<TeacherModel>.Fail($"Teacher with ID {id} not found"));

        return Ok(ApiResponse<TeacherModel>.Success(teacher));
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<TeacherModel>>>> GetAll()
    {
        var teachers = await _teacherService.GetAllTeachersAsync();
        return Ok(ApiResponse<IEnumerable<TeacherModel>>.Success(teachers));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<TeacherModel>>> Update(string id, [FromBody] UpdateTeacherRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<TeacherModel>.Fail("Teacher payload is required"));

        var existing = await _teacherService.GetTeacherByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<TeacherModel>.Fail($"Teacher with ID {id} not found"));

        existing.Email = request.Email;
        existing.FirstName = request.FirstName;
        existing.LastName = request.LastName;
        existing.Phone = request.Phone;
        existing.Matricule = request.Matricule;
        existing.TitleId = request.TitleId;

        await _teacherService.UpdateTeacherAsync(existing);
        return Ok(ApiResponse<TeacherModel>.Success(existing, "Teacher updated successfully"));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        var existing = await _teacherService.GetTeacherByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<string>.Fail($"Teacher with ID {id} not found"));

        await _teacherService.DeleteTeacherAsync(id);
        return Ok(ApiResponse<string>.Success(id, "Teacher deleted successfully"));
    }
}