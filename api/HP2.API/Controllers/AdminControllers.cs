using HP2.Application.Contracts;
using HP2.Application.DTOs.Admin;
using HP2.Application.DTOs.Common;
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
    public async Task<ActionResult<ApiResponse<AdminResponse>>> Create([FromBody] AdminModel admin)
    {
        if (admin == null)
            return BadRequest();

        var createdAdmin = await _adminService.CreateAdminAsync(admin);

        var response = new AdminResponse
        {
            Id = createdAdmin.Id,
            Email = createdAdmin.Email,
            FirstName = createdAdmin.FirstName,
            LastName = createdAdmin.LastName,
            Phone = createdAdmin.Phone,
            Role = createdAdmin.Role,
            CreatedAt = createdAdmin.CreatedAt,
            UpdatedAt = createdAdmin.UpdatedAt
        };

        return Ok(new ApiResponse<AdminResponse>
        {
            Status = "success",
            Message = "Admin created",
            Result = response
        });
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<AdminResponse>>> Get(string id)
    {
        var admin = await _adminService.GetAdminByIdAsync(id);

        if (admin == null)
            return NotFound();

        var response = new AdminResponse
        {
            Id = admin.Id,
            Email = admin.Email,
            FirstName = admin.FirstName,
            LastName = admin.LastName,
            Phone = admin.Phone,
            Role = admin.Role,
            CreatedAt = admin.CreatedAt,
            UpdatedAt = admin.UpdatedAt
        };

        return Ok(new ApiResponse<AdminResponse>
        {
            Status = "success",
            Message = "",
            Result = response
        });
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<List<AdminResponse>>>> GetAll()
    {
        var admins = await _adminService.GetAllAdminsAsync();

        var response = admins.Select(a => new AdminResponse
        {
            Id = a.Id,
            Email = a.Email,
            FirstName = a.FirstName,
            LastName = a.LastName,
            Phone = a.Phone,
            Role = a.Role,
            CreatedAt = a.CreatedAt,
            UpdatedAt = a.UpdatedAt
        }).ToList();

        return Ok(new ApiResponse<List<AdminResponse>>
        {
            Status = "success",
            Message = "",
            Result = response
        });
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

        return Ok(new ApiResponse<string>
        {
            Status = "success",
            Message = "Admin updated",
            Result = id
        });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var existing = await _adminService.GetAdminByIdAsync(id);

        if (existing == null)
            return NotFound($"Admin with ID {id} not found");

        await _adminService.DeleteAdminAsync(id);

        return Ok(new ApiResponse<string>
        {
            Status = "success",
            Message = "Admin deleted",
            Result = id
        });
    }
}