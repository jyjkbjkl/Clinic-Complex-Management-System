using Clinic_Complex_Management_System.Data;
using Clinic_Complex_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clinic_Complex_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSlotController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TimeSlotController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<TimeSlot>> CreateTimeSlot([FromBody]TimeSlot timeSlot)
        {
            _context.TimeSlots.Add(timeSlot);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTimeSlotById), new { id = timeSlot.Id }, timeSlot);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TimeSlot>> GetTimeSlotById(int id)
        {
            var timeSlot = await _context.TimeSlots.FindAsync(id);
            if (timeSlot == null)
                return NotFound();

            return timeSlot;
        }

    }
}
