using AutoMapper;
using HP2.Application.Contracts;
using HP2.Application.DTOs.Common;
using HP2.Application.DTOs.Session;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SessionsController : ControllerBase
    {
        private readonly ISessionService _service;
        private readonly IMapper _mapper;

        public SessionsController(ISessionService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<List<SessionResponse>>>> GetAll()
        {
            var sessions = await _service.GetAllAsync();
            var response = _mapper.Map<List<SessionResponse>>(sessions);

            return Ok(ApiResponse<List<SessionResponse>>.Success(response, "Sessions retrieved successfully."));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<SessionResponse>>> GetById(string id)
        {
            var session = await _service.GetByIdAsync(id);

            if (session == null)
                return NotFound(ApiResponse<string>.Fail("Session not found"));

            var response = _mapper.Map<SessionResponse>(session);

            return Ok(ApiResponse<SessionResponse>.Success(response, "Session retrieved successfully."));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<SessionResponse>>> Create([FromBody] CreateSessionRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ApiResponse<string>.Fail("Invalid request data"));

            var model = _mapper.Map<HP2.Domain.Models.SessionModel>(request);
            var createdSession = await _service.AddAsync(model);
            var response = _mapper.Map<SessionResponse>(createdSession);

            return CreatedAtAction(nameof(GetById), new { id = response.Id }, ApiResponse<SessionResponse>.Success(response, "Session created successfully."));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<SessionResponse>>> Update(string id, [FromBody] UpdateSessionRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ApiResponse<string>.Fail("Invalid request data"));

            var model = _mapper.Map<HP2.Domain.Models.SessionModel>(request);
            model.Id = id;

            var updatedSession = await _service.UpdateAsync(model);

            if (updatedSession == null)
                return NotFound(ApiResponse<string>.Fail("Session not found"));

            var response = _mapper.Map<SessionResponse>(updatedSession);

            return Ok(ApiResponse<SessionResponse>.Success(response, "Session updated successfully."));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
        {
            var result = await _service.DeleteAsync(id);

            if (!result)
                return NotFound(ApiResponse<string>.Fail("Session not found"));

            return Ok(ApiResponse<string>.Success("Session deleted successfully."));
        }

        [HttpGet("filter")]
        public async Task<ActionResult<ApiResponse<List<SessionResponse>>>> Filter(
            [FromQuery] DateTime? startDate,
            [FromQuery] DateTime? endDate,
            [FromQuery] string? trackId,
            [FromQuery] string? courseId,
            [FromQuery] string? roomId)
        {
            var sessions = await _service.GetAllAsync();

            if (startDate.HasValue)
                sessions = sessions.Where(s => s.Date >= startDate.Value);
            if (endDate.HasValue)
                sessions = sessions.Where(s => s.Date <= endDate.Value);
            if (!string.IsNullOrEmpty(trackId))
                sessions = sessions.Where(s => s.CourseId == trackId); // À adapter si trackId est ailleurs
            if (!string.IsNullOrEmpty(courseId))
                sessions = sessions.Where(s => s.CourseId == courseId);
            if (!string.IsNullOrEmpty(roomId))
                sessions = sessions.Where(s => s.RoomId == roomId);

            var response = _mapper.Map<List<SessionResponse>>(sessions.ToList());
            return Ok(ApiResponse<List<SessionResponse>>.Success(response, "Sessions filtrées."));
        }
    }
}