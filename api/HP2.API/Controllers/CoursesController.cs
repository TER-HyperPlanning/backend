using AutoMapper;
using HP2.Application.Contracts;
using HP2.Domain.Models;
using HP2.Application.DTOs.Course;
using HP2.Application.DTOs.Common;
using HP2.Application.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace HP2.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "ADMIN")]
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

            try
            {
                var course = await _service.AddAsync(model);
                var response = _mapper.Map<CourseResponse>(course);
                return Ok(ApiResponse<CourseResponse>.Success(response, "Course created successfully."));
            }
            catch (DbUpdateException dbEx)
            {
                var inner = dbEx.InnerException?.Message ?? dbEx.Message;
                if (inner.Contains("duplicate key", StringComparison.OrdinalIgnoreCase) || inner.Contains("unique", StringComparison.OrdinalIgnoreCase))
                    return BadRequest(ApiResponse<string>.Fail("A course with the same code or unique field already exists."));

                return StatusCode(500, ApiResponse<string>.Fail("Database update error."));
            }
            catch (Exception)
            {
                return StatusCode(500, ApiResponse<string>.Fail("Internal server error."));
            }
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

            try
            {
                await _service.UpdateAsync(existing);
                var response = _mapper.Map<CourseResponse>(existing);
                return Ok(ApiResponse<CourseResponse>.Success(response, "Course updated"));
            }
            catch (DbUpdateException dbEx)
            {
                var inner = dbEx.InnerException?.Message ?? dbEx.Message;
                if (inner.Contains("duplicate key", StringComparison.OrdinalIgnoreCase) || inner.Contains("unique", StringComparison.OrdinalIgnoreCase))
                    return BadRequest(ApiResponse<string>.Fail("A course with the same code or unique field already exists."));

                return StatusCode(500, ApiResponse<string>.Fail("Database update error."));
            }
            catch (Exception)
            {
                return StatusCode(500, ApiResponse<string>.Fail("Internal server error."));
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse<object>>> Delete(string id)
        {
            var existing = await _service.GetByIdAsync(id);
            if (existing == null)
                return NotFound(ApiResponse<object>.Fail("Course not found"));

            try
            {
                await _service.DeleteAsync(id);
                return Ok(ApiResponse<object>.Success(id, "Course deleted"));
            }
            catch (DeleteConflictException ex)
            {
                return Conflict(ApiResponse<object>.Fail(ex.Message, ex.BlockingSession));
            }
        }

        [HttpGet("deleted")]
        public async Task<ActionResult<ApiResponse<List<DeletedCourseResponse>>>> GetDeleted()
        {
            var deletedCourses = await _service.GetDeletedAsync();
            var response = deletedCourses.Select(MapToDeletedResponse).ToList();
            return Ok(ApiResponse<List<DeletedCourseResponse>>.Success(response, "Deleted courses retrieved successfully."));
        }

        private static DeletedCourseResponse MapToDeletedResponse(CourseModel course)
        {
            return new DeletedCourseResponse
            {
                Id = course.Id,
                Name = course.Name,
                Code = course.Code,
                DeletedAt = course.DeletedAt
            };
        }
    }
}