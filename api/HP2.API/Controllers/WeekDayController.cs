using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HP2.Infrastructure.Persistence.Entities;

namespace HP2.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeekDayController : ControllerBase
    {
        private readonly TerHyperplanningContext _context;

        public WeekDayController(TerHyperplanningContext context)
        {
            _context = context;
        }

        // GET: api/WeekDay
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _context.WeekDays
                .OrderBy(w => w.OrderIndex)
                .Select(w => new
                {
                    w.WeekdayId,
                    w.OrderIndex,
                    w.Name
                })
                .ToListAsync();

            return Ok(items);
        }

        // GET: api/WeekDay/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var item = await _context.WeekDays
                .Where(w => w.WeekdayId == id)
                .Select(w => new
                {
                    w.WeekdayId,
                    w.OrderIndex,
                    w.Name
                })
                .FirstOrDefaultAsync();

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

        // POST: api/WeekDay
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateWeekDayRequest req)
        {
            var exists = await _context.WeekDays.AnyAsync(w => w.WeekdayId == req.WeekdayId);
            if (exists) return Conflict($"WeekDay with id '{req.WeekdayId}' already exists");

            var entity = new WeekDay
            {
                WeekdayId = req.WeekdayId,
                OrderIndex = req.OrderIndex,
                Name = req.Name
            };

            _context.WeekDays.Add(entity);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = entity.WeekdayId }, new
            {
                entity.WeekdayId,
                entity.OrderIndex,
                entity.Name
            });
        }

        // PUT: api/WeekDay/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] UpdateWeekDayRequest req)
        {
            var entity = await _context.WeekDays.FirstOrDefaultAsync(w => w.WeekdayId == id);
            if (entity == null) return NotFound($"WeekDay with id '{id}' not found");

            entity.OrderIndex = req.OrderIndex;
            entity.Name = req.Name;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/WeekDay/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var entity = await _context.WeekDays.FirstOrDefaultAsync(w => w.WeekdayId == id);
            if (entity == null) return NotFound($"WeekDay with id '{id}' not found");

            _context.WeekDays.Remove(entity);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
