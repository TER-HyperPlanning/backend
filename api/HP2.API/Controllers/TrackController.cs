using AutoMapper;
using AutoMapper;
using HP2.Application.Contracts;
using HP2.Application.DTOs.Track;
using HP2.Application.DTOs.Group;
using HP2.Application.DTOs.Student;
using HP2.Application.DTOs.Common;
using HP2.Application.Exceptions;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace HP2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TracksController : ControllerBase
{
    private readonly ITrackService _trackService;
    private readonly IGroupService _groupService;
    private readonly IStudentService _studentService;
    private readonly IMapper _mapper;

    public TracksController(ITrackService trackService, IGroupService groupService, IStudentService studentService, IMapper mapper)
    {
        _trackService = trackService;
        _groupService = groupService;
        _studentService = studentService;
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
    [AllowAnonymous]
    public async Task<ActionResult<ApiResponse<TrackWithGroupsResponse>>> Get(string id)
    {
        var track = await _trackService.GetByIdAsync(id);
        if (track == null)
            return NotFound(ApiResponse<string>.Fail("Track not found"));

        var groups = (await _groupService.GetGroupsByTrackIdAsync(id)).ToList();
        var groupResponses = new List<GroupWithStudentsResponse>();
        var allStudents = new List<StudentResponse>();

        foreach (var group in groups)
        {
            var students = (await _studentService.GetStudentsByGroupIdAsync(group.Id)).ToList();
            var studentResponses = students.Select(MapToStudentResponse).ToList();

            groupResponses.Add(new GroupWithStudentsResponse
            {
                Id = group.Id,
                Name = group.Name,
                AcademicYear = group.AcademicYear,
                TrackId = group.TrackId,
                Students = studentResponses
            });

            allStudents.AddRange(studentResponses);
        }

        var response = new TrackWithGroupsResponse
        {
            Id = track.Id,
            Name = track.Name,
            TeacherId = track.TeacherId,
            ProgramId = track.ProgramId,
            Description = track.Description,
            Lieu = track.Lieu,
            DeletedAt = track.DeletedAt,
            Groups = groupResponses,
            Students = allStudents
        };

        return Ok(ApiResponse<TrackWithGroupsResponse>.Success(response, "Track retrieved successfully"));
    }

    private static StudentResponse MapToStudentResponse(StudentModel student)
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
            DeletedAt = student.DeletedAt,
        };
    }

    [HttpGet]
    [AllowAnonymous]
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
        try
        {
            var deleted = await _trackService.DeleteAsync(id);
            if (!deleted) return NotFound(ApiResponse<string>.Fail("Track not found"));

            return Ok(ApiResponse<string>.Success(id, "Track deleted successfully"));
        }
        catch (DeleteConflictException ex)
        {
            return Conflict(ApiResponse<object>.Fail(ex.Message, ex.BlockingResource));
        }
    }

    [HttpGet("deleted")]
    public async Task<ActionResult<ApiResponse<List<TrackResponse>>>> GetDeleted()
    {
        var tracks = await _trackService.GetDeletedAsync();
        var response = tracks.Select(t => _mapper.Map<TrackResponse>(t)).ToList();
        
        return Ok(ApiResponse<List<TrackResponse>>.Success(response, "Deleted tracks retrieved successfully"));
    }
}