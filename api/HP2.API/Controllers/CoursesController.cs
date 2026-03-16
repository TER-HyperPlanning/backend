using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Application.DTOs.Course;
using HP2.Application.DTOs.Common;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _service;
        private readonly IMapper _mapper;

        public CoursesController(ICourseService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse<List<CourseResponse>>>> GetAll()
        {
            var courses = await _service.GetAllAsync();
            var response = _mapper.Map<List<CourseResponse>>(courses);

            return Ok(ApiResponse<List<CourseResponse>>.Success(response, "Courses retrieved successfully."));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<CourseResponse>>> GetById(string id)
        {
            var course = await _service.GetByIdAsync(id);

            if (course == null)
                return NotFound(ApiResponse<string>.Fail("Course not found"));

            var response = _mapper.Map<CourseResponse>(course);

            return Ok(ApiResponse<CourseResponse>.Success(response, "Course retrieved successfully."));
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<CourseResponse>>> Create([FromBody] CreateCourseRequest request)
        {
            if (!ModelState.IsValid)
            {
                var missing = ModelState.Where(kv => kv.Value.Errors.Count > 0)
                    .Select(kv => kv.Key.Split('.').Last())
                    .ToList();
                return BadRequest(ApiResponse<string>.Fail($"Missing required fields: {string.Join(", ", missing)}"));
            }

            var model = _mapper.Map<CourseModel>(request);

            var course = await _service.AddAsync(model);

            var response = _mapper.Map<CourseResponse>(course);

            return Ok(ApiResponse<CourseResponse>.Success(response, "Course created successfully."));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponse<CourseResponse>>> Update(string id, [FromBody] UpdateCourseRequest request)
        {
            if (!ModelState.IsValid)
            {
                var missing = ModelState.Where(kv => kv.Value.Errors.Count > 0)
                    .Select(kv => kv.Key.Split('.').Last())
                    .ToList();
                return BadRequest(ApiResponse<string>.Fail($"Missing required fields: {string.Join(", ", missing)}"));
            }

            var existing = await _service.GetByIdAsync(id);
            if (existing == null)
                return NotFound(ApiResponse<string>.Fail("Course not found"));

            existing.Name = request.Name;
            existing.Code = request.Code;

            var updated = await _service.UpdateAsync(existing);
            var response = _mapper.Map<CourseResponse>(updated);

            return Ok(ApiResponse<CourseResponse>.Success(response, "Course updated"));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse<string>>> Delete(string id)
        {
            var deleted = await _service.DeleteAsync(id);

            if (!deleted)
                return NotFound(ApiResponse<string>.Fail("Course not found"));

            return Ok(ApiResponse<string>.Success("", "Course deleted"));
        }
    }
}