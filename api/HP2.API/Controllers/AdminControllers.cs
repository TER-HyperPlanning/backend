using HP2.Application.Contracts;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AdminsController : ControllerBase
{
    private readonly IAdminService _adminService;

    public AdminsController(IAdminService adminService)
    {
        _adminService = adminService;
    }

    [HttpPost]
    public async Task<ActionResult<AdminModel>> Create([FromBody] AdminModel admin)
    {
        if (admin == null)
            return BadRequest();

        var createdAdmin = await _adminService.CreateAdminAsync(admin);
        return CreatedAtAction(nameof(Get), new { id = createdAdmin.Id }, createdAdmin);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AdminModel>> Get(string id)
    {
        var admin = await _adminService.GetAdminByIdAsync(id);

        if (admin == null)
            return NotFound();

        return Ok(admin);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AdminModel>>> GetAll()
    {
        var admins = await _adminService.GetAllAdminsAsync();
        return Ok(admins);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] AdminModel admin)
    {
        if (admin == null)
            return BadRequest();

        if (id != admin.Id)
            return BadRequest("ID mismatch");

        var existing = await _adminService.GetAdminByIdAsync(id);

        if (existing == null)
            return NotFound($"Admin with ID {id} not found");

        await _adminService.UpdateAdminAsync(admin);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var existing = await _adminService.GetAdminByIdAsync(id);

        if (existing == null)
            return NotFound($"Admin with ID {id} not found");

        await _adminService.DeleteAdminAsync(id);

        return NoContent();
    }
}