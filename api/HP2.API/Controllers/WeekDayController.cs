using HP2.Application.Contracts;
using HP2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace HP2.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeekDayController : ControllerBase
    {
        private readonly IWeekDayService _weekDayService;

        public WeekDayController(IWeekDayService weekDayService)
        {
            _weekDayService = weekDayService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _weekDayService.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var item = await _weekDayService.GetByIdAsync(id);
            if (item == null) return NotFound($"WeekDay with id '{id}' not found");
            return Ok(item);
        }

        public class CreateWeekDayRequest
        {
            public string WeekdayId { get; set; } = null!;
            public byte OrderIndex { get; set; }
            public string Name { get; set; } = null!;
        }

        public class UpdateWeekDayRequest
        {
            public byte OrderIndex { get; set; }
            public string Name { get; set; } = null!;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateWeekDayRequest req)
        {
            try
            {
                var created = await _weekDayService.CreateAsync(new WeekDayModel
                {
                    WeekdayId = req.WeekdayId,
                    OrderIndex = req.OrderIndex,
                    Name = req.Name
                });

                return CreatedAtAction(nameof(GetById), new { id = created.WeekdayId }, created);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] UpdateWeekDayRequest req)
        {
            var updated = await _weekDayService.UpdateAsync(id, req.OrderIndex, req.Name);
            if (!updated) return NotFound($"WeekDay with id '{id}' not found");
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var deleted = await _weekDayService.DeleteAsync(id);
            if (!deleted) return NotFound($"WeekDay with id '{id}' not found");
            return NoContent();
        }
    }
}
