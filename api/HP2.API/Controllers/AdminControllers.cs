using HP2.Application.Contracts;
using HP2.Application.DTOs.Admin;
using HP2.Application.DTOs.Common;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers;

[Route("api/[controller]")]
public class AdminsController : ControllerBase
{
    private readonly IAdminService _adminService;

    public AdminsController(IAdminService adminService)
    {
        _adminService = adminService;
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<AdminResponse>>> Create([FromBody] CreateAdminRequest request)
    {
        if (!ModelState.IsValid)
        {
            var errors = string.Join("; ", ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage));

            return BadRequest(ApiResponse<AdminResponse>.Fail(errors));
        }

        try
        {
            var adminModel = new AdminModel
            {
                Email = request.Email,
                Password = request.Password,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Phone = request.Phone
            };

            var createdAdmin = await _adminService.CreateAdminAsync(adminModel);

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

            return Ok(ApiResponse<AdminResponse>.Success(response, "Admin created"));
        }
        catch (Exception ex)
        {
            return BadRequest(ApiResponse<AdminResponse>.Fail(ex.Message));
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<AdminResponse>>> Get(string id)
    {
        try
        {
            var admin = await _adminService.GetAdminByIdAsync(id);

            if (admin == null)
                return NotFound(ApiResponse<AdminResponse>.Fail($"Admin with ID {id} not found"));

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

            return Ok(ApiResponse<AdminResponse>.Success(response, "Admin retrieved"));
        }
        catch (Exception ex)
        {
            return BadRequest(ApiResponse<AdminResponse>.Fail(ex.Message));
        }
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<List<AdminResponse>>>> GetAll()
    {
        try
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

            return Ok(ApiResponse<List<AdminResponse>>.Success(response, "Admins retrieved"));
        }
        catch (Exception ex)
        {
            return BadRequest(ApiResponse<List<AdminResponse>>.Fail(ex.Message));
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<AdminResponse>>> Update(string id, [FromBody] UpdateAdminRequest request)
    {
        if (!ModelState.IsValid)
        {
            var errors = string.Join("; ", ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage));

            return BadRequest(ApiResponse<AdminResponse>.Fail(errors));
        }

        try
        {
            var existing = await _adminService.GetAdminByIdAsync(id);
            if (existing == null)
                return NotFound(ApiResponse<AdminResponse>.Fail($"Admin with ID {id} not found"));

            existing.Email = request.Email;
            existing.FirstName = request.FirstName;
            existing.LastName = request.LastName;
            existing.Phone = request.Phone;

            await _adminService.UpdateAdminAsync(existing);

            var response = new AdminResponse
            {
                Id = existing.Id,
                Email = existing.Email,
                FirstName = existing.FirstName,
                LastName = existing.LastName,
                Phone = existing.Phone,
                Role = existing.Role,
                CreatedAt = existing.CreatedAt,
                UpdatedAt = existing.UpdatedAt
            };

            return Ok(ApiResponse<AdminResponse>.Success(response, "Admin updated"));
        }
        catch (Exception ex)
        {
            return BadRequest(ApiResponse<AdminResponse>.Fail(ex.Message));
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
    {
        try
        {
            var existing = await _adminService.GetAdminByIdAsync(id);
            if (existing == null)
                return NotFound(ApiResponse<string>.Fail($"Admin with ID {id} not found"));

            await _adminService.DeleteAdminAsync(id);

            return Ok(ApiResponse<string>.Success(id, "Admin deleted"));
        }
        catch (Exception ex)
        {
            return BadRequest(ApiResponse<string>.Fail(ex.Message));
        }
    }
}