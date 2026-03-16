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
        public async Task<IActionResult> GetAll()
        {
            var courses = await _service.GetAllAsync();
            var response = _mapper.Map<List<CourseResponse>>(courses);

            return Ok(ApiResponse<List<CourseResponse>>.Success(response, "Courses retrieved successfully."));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var course = await _service.GetByIdAsync(id);

            if (course == null)
                return NotFound(ApiResponse<string>.Fail("Course not found"));

            var response = _mapper.Map<CourseResponse>(course);

            return Ok(ApiResponse<CourseResponse>.Success(response, "Course retrieved successfully."));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCourseRequest request)
        {
            var model = _mapper.Map<CourseModel>(request);

            var course = await _service.AddAsync(model);

            var response = _mapper.Map<CourseResponse>(course);

            return Ok(ApiResponse<CourseResponse>.Success(response, "Course created successfully."));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] CourseModel model)
        {
            model.Id = id;

            var updated = await _service.UpdateAsync(model);

            if (updated == null)
                return NotFound(ApiResponse<string>.Fail("Course not found"));

            var response = _mapper.Map<CourseResponse>(updated);

            return Ok(ApiResponse<CourseResponse>.Success(response, "Course updated"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var deleted = await _service.DeleteAsync(id);

            if (!deleted)
                return NotFound(ApiResponse<string>.Fail("Course not found"));

            return Ok(ApiResponse<string>.Success("", "Course deleted"));
        }
    }
}