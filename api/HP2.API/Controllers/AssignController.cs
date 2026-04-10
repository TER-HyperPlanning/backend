using Microsoft.AspNetCore.Mvc;
using HP2.Application.Contracts;
using HP2.Application.DTOs.Assign;
using HP2.Application.DTOs.Common;
using Microsoft.AspNetCore.Authorization;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AssignController : ControllerBase
{
    private readonly IAssignService _service;

    public AssignController(IAssignService service)
    {
        _service = service;
    }

    [HttpGet]
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<List<AssignResponse>>>> GetAll()
    {
        var response = await _service.GetAllAsync();
        return Ok(response);
    }

    [HttpGet("{trackId}/{courseId}")]
    public async Task<ActionResult<ApiResponse<AssignResponse>>> Get(string trackId, string courseId)
    {
        var response = await _service.GetByIdsAsync(trackId, courseId);
        return Ok(response);
    }

    [HttpPost]
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<bool>>> Create([FromBody] CreateAssignRequest request)
    {
        var response = await _service.CreateAsync(request);
        return Ok(response);
    }

    [HttpPut("{trackId}/{courseId}")]
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<bool>>> Update(string trackId,string courseId,[FromBody] UpdateAssignRequest request)
    {
        var response = await _service.UpdateAsync(trackId, courseId, request);
        return Ok(response);
    }

    [HttpDelete("{trackId}/{courseId}")]
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<bool>>> Delete(string trackId, string courseId)
    {
        var response = await _service.DeleteAsync(trackId, courseId);
        return Ok(response);
    }

    [HttpGet("deleted")]
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<List<AssignResponse>>>> GetDeleted()
    {
        var response = await _service.GetDeletedAsync();
        return Ok(response);
    }
}