using AutoMapper;
using HP2.Application.Contracts;
using HP2.Application.DTOs.Track;
using HP2.Application.DTOs.Common;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TracksController : ControllerBase
{
    private readonly ITrackService _trackService;
    private readonly IMapper _mapper;

    public TracksController(ITrackService trackService, IMapper mapper)
    {
        _trackService = trackService;
        _mapper = mapper;
    }

    [HttpPost]
    [Authorize(Roles = "ADMIN")]
    public async Task<ActionResult<ApiResponse<TrackResponse>>> Create([FromBody] CreateTrackRequest request)
    {
        if (request == null) return BadRequest();

        var missing = new List<string>();
        if (string.IsNullOrWhiteSpace(request.Name)) missing.Add("name");
        if (string.IsNullOrWhiteSpace(request.TeacherId)) missing.Add("teacherId");
        if (string.IsNullOrWhiteSpace(request.ProgramId)) missing.Add("programId");
        if (missing.Any())
            return BadRequest(ApiResponse<TrackResponse>.Fail($"Missing required fields: {string.Join(", ", missing)}"));

        var trackModel = _mapper.Map<TrackModel>(request);
        trackModel.Id = Guid.NewGuid().ToString();
        try
        {
            var createdTrack = await _trackService.AddAsync(trackModel);
            var response = _mapper.Map<TrackResponse>(createdTrack);
            return Ok(ApiResponse<TrackResponse>.Success(response, "Track created successfully"));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<TrackResponse>.Fail(ex.Message));
        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<TrackResponse>.Fail("An internal error occurred."));
        }
    }

    [HttpGet("{id}")]
    [Authorize(Roles = "ADMIN,TEACHER,STUDENT")]
    public async Task<ActionResult<ApiResponse<TrackResponse>>> Get(string id)
    {
        var track = await _trackService.GetByIdAsync(id);
        if (track == null)
            return NotFound(ApiResponse<string>.Fail("Track not found"));

        var response = _mapper.Map<TrackResponse>(track);
        return Ok(ApiResponse<TrackResponse>.Success(response, "Track retrieved successfully"));
    }

    [HttpGet]
    [Authorize(Roles = "ADMIN,TEACHER,STUDENT")]
    public async Task<ActionResult<ApiResponse<List<TrackResponse>>>> GetAll()
    {
        var tracks = await _trackService.GetAllAsync();
        var response = tracks.Select(t => _mapper.Map<TrackResponse>(t)).ToList();

        return Ok(ApiResponse<List<TrackResponse>>.Success(response, "Tracks retrieved successfully"));
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "ADMIN")]
    public async Task<IActionResult> Update(string id, [FromBody] UpdateTrackRequest request)
    {
        if (request == null) return BadRequest();

        var existing = await _trackService.GetByIdAsync(id);
        if (existing == null) return NotFound(ApiResponse<string>.Fail("Track not found"));
        var missing = new List<string>();
        if (string.IsNullOrWhiteSpace(request.Name)) missing.Add("name");
        if (string.IsNullOrWhiteSpace(request.TeacherId)) missing.Add("teacherId");
        if (string.IsNullOrWhiteSpace(request.ProgramId)) missing.Add("programId");
        if (missing.Any())
            return BadRequest(ApiResponse<TrackResponse>.Fail($"Missing required fields: {string.Join(", ", missing)}"));

        existing.Name = request.Name;
        existing.TeacherId = request.TeacherId;
        existing.ProgramId = request.ProgramId;
        existing.Description = request.Description;
        existing.Lieu = request.Lieu;
        try
        {
            var updated = await _trackService.UpdateAsync(existing);
            var response = _mapper.Map<TrackResponse>(updated);
            return Ok(ApiResponse<TrackResponse>.Success(response, "Track updated successfully"));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ApiResponse<TrackResponse>.Fail(ex.Message));
        }
        catch (Exception)
        {
            return StatusCode(500, ApiResponse<TrackResponse>.Fail("An internal error occurred."));
        }
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "ADMIN")]
    public async Task<IActionResult> Delete(string id)
    {
        var deleted = await _trackService.DeleteAsync(id);
        if (!deleted) return NotFound(ApiResponse<string>.Fail("Track not found"));

        return Ok(ApiResponse<string>.Success(id, "Track deleted successfully"));
    }

    [HttpGet("deleted")]
    public async Task<ActionResult<ApiResponse<List<TrackResponse>>>> GetDeleted()
    {
        var tracks = await _trackService.GetDeletedAsync();
        var response = tracks.Select(t => _mapper.Map<TrackResponse>(t)).ToList();
        
        return Ok(ApiResponse<List<TrackResponse>>.Success(response, "Deleted tracks retrieved successfully"));
    }
}