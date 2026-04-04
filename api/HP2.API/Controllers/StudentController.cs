using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Student;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = "ADMIN")]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<StudentResponse>>> Create([FromBody] CreateStudentRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<StudentResponse>.Fail("Student payload is required"));

        var missing = new List<string>();
        if (string.IsNullOrWhiteSpace(request.Email)) missing.Add("email");
        if (string.IsNullOrWhiteSpace(request.Password)) missing.Add("password");
        if (string.IsNullOrWhiteSpace(request.FirstName)) missing.Add("firstName");
        if (string.IsNullOrWhiteSpace(request.LastName)) missing.Add("lastName");
        if (string.IsNullOrWhiteSpace(request.GroupId)) missing.Add("groupId");

        if (missing.Any())
            return BadRequest(ApiResponse<StudentResponse>.Fail($"Missing required fields: {string.Join(", ", missing)}"));

        if (!await _studentService.GroupExistsAsync(request.GroupId!))
            return BadRequest(ApiResponse<StudentResponse>.Fail($"Group with ID '{request.GroupId}' not found"));

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
            ApiResponse<StudentResponse>.Success(MapToResponse(createdStudent), "Student created successfully"));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<StudentResponse>>> Get(string id)
    {
        var student = await _studentService.GetStudentByIdAsync(id);
        if (student == null)
            return NotFound(ApiResponse<StudentResponse>.Fail($"Student with ID {id} not found"));

        return Ok(ApiResponse<StudentResponse>.Success(MapToResponse(student)));
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<StudentResponse>>>> GetAll()
    {
        var students = await _studentService.GetAllStudentsAsync();
        var response = students.Select(MapToResponse);
        return Ok(ApiResponse<IEnumerable<StudentResponse>>.Success(response));
    }

    [HttpGet("deleted")]
    public async Task<ActionResult<ApiResponse<IEnumerable<DeletedStudentResponse>>>> GetDeleted()
    {
        var students = await _studentService.GetDeletedStudentsAsync();
        var response = students.Select(MapToDeletedResponse);
        return Ok(ApiResponse<IEnumerable<DeletedStudentResponse>>.Success(response));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<StudentResponse>>> Update(string id, [FromBody] UpdateStudentRequest request)
    {
        if (request == null)
            return BadRequest(ApiResponse<StudentResponse>.Fail("Student payload is required"));

        var missing = new List<string>();
        if (string.IsNullOrWhiteSpace(request.Email)) missing.Add("email");
        if (string.IsNullOrWhiteSpace(request.FirstName)) missing.Add("firstName");
        if (string.IsNullOrWhiteSpace(request.LastName)) missing.Add("lastName");
        if (string.IsNullOrWhiteSpace(request.GroupId)) missing.Add("groupId");

        if (missing.Any())
            return BadRequest(ApiResponse<StudentResponse>.Fail($"Missing required fields: {string.Join(", ", missing)}"));

        if (!await _studentService.GroupExistsAsync(request.GroupId!))
            return BadRequest(ApiResponse<StudentResponse>.Fail($"Group with ID {request.GroupId} not found"));

        var existing = await _studentService.GetStudentByIdAsync(id);
        if (existing == null)
            return NotFound(ApiResponse<StudentResponse>.Fail($"Student with ID {id} not found"));

        existing.Email = request.Email;
        existing.FirstName = request.FirstName;
        existing.LastName = request.LastName;
        existing.Phone = request.Phone;
        existing.GroupId = request.GroupId;

        await _studentService.UpdateStudentAsync(existing);
        return Ok(ApiResponse<StudentResponse>.Success(MapToResponse(existing), "Student updated successfully"));
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

    private static StudentResponse MapToResponse(StudentModel student)
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
        };
    }

    private static DeletedStudentResponse MapToDeletedResponse(StudentModel student)
    {
        return new DeletedStudentResponse
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
            IsDeleted = student.IsDeleted,
            DeletedAt = student.DeletedAt,
        };
    }
}
