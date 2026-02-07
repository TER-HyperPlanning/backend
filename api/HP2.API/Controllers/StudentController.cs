using HP2.Application.Contracts;
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
    public async Task<ActionResult<StudentModel>> Create([FromBody] StudentModel student)
    {
        if (student == null)
            return BadRequest();

        var createdStudent = await _studentService.CreateStudentAsync(student);
        return CreatedAtAction(nameof(Get), new { id = createdStudent.Id }, createdStudent);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<StudentModel>> Get(string id)
    {
        var student = await _studentService.GetStudentByIdAsync(id);
        if (student == null)
            return NotFound();
        
        return Ok(student);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<StudentModel>>> GetAll()
    {
        var students = await _studentService.GetAllStudentsAsync();
        return Ok(students);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] StudentModel student)
    {
        if (student == null)
            return BadRequest();

        if (id != student.Id)
            return BadRequest("ID mismatch");

        var existing = await _studentService.GetStudentByIdAsync(id);
        if (existing == null)
            return NotFound($"Student with ID {id} not found");

        await _studentService.UpdateStudentAsync(student);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var existing = await _studentService.GetStudentByIdAsync(id);
        if (existing == null)
            return NotFound($"Student with ID {id} not found");

        await _studentService.DeleteStudentAsync(id);
        return NoContent();
    }
}
