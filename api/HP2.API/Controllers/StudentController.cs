using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Student;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<StudentModel>>> Create([FromBody] CreateStudentRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<StudentModel>.Fail("Student payload is required"));

        var student = new StudentModel
        {
            Email = request.Email,
            Password = request.Password,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Phone = request.Phone,
            GroupId = request.GroupId,
        };

        var createdStudent = await _studentService.CreateStudentAsync(student);
        return CreatedAtAction(nameof(Get), new { id = createdStudent.Id },
            ApiResponse<StudentModel>.Success(createdStudent, "Student created successfully"));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<StudentModel>>> Get(string id)
    {
        var student = await _studentService.GetStudentByIdAsync(id);
        if (student == null)
            return NotFound(ApiResponse<StudentModel>.Fail($"Student with ID {id} not found"));

        return Ok(ApiResponse<StudentModel>.Success(student));
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<StudentModel>>>> GetAll()
    {
        var students = await _studentService.GetAllStudentsAsync();
        return Ok(ApiResponse<IEnumerable<StudentModel>>.Success(students));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<StudentModel>>> Update(string id, [FromBody] UpdateStudentRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<StudentModel>.Fail("Student payload is required"));

        var existing = await _studentService.GetStudentByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<StudentModel>.Fail($"Student with ID {id} not found"));

        existing.Email = request.Email;
        existing.FirstName = request.FirstName;
        existing.LastName = request.LastName;
        existing.Phone = request.Phone;
        existing.GroupId = request.GroupId;

        await _studentService.UpdateStudentAsync(existing);
        return Ok(ApiResponse<StudentModel>.Success(existing, "Student updated successfully"));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        var existing = await _studentService.GetStudentByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<string>.Fail($"Student with ID {id} not found"));

        await _studentService.DeleteStudentAsync(id);
        return Ok(ApiResponse<string>.Success(id, "Student deleted successfully"));
    }
}
