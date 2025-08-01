using Clinic_Complex_Management_System.Data;
using Clinic_Complex_Management_System.DTOs;
using Clinic_Complex_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class AppointmentsController : ControllerBase
{
    private readonly AppDbContext _context;

    public AppointmentsController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/appointments
    [HttpGet]
    public async Task<IActionResult> GetAllAppointments()
    {
        var appointments = await _context.Appointments
            .Include(a => a.Doctor)
            .Include(a => a.Room)
            .ToListAsync();

        return Ok(appointments);
    }

    // GET: api/appointments/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAppointment(int id)
    {
        var appointment = await _context.Appointments
            .Include(a => a.Doctor)
            .Include(a => a.Room)
            .FirstOrDefaultAsync(a => a.Id == id);

        if (appointment == null) return NotFound();

        return Ok(appointment);
    }

    // POST: api/appointments
    [HttpPost]
    public async Task<IActionResult> CreateAppointment([FromBody] AppointmentCreateDTO dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var appointment = new Appointment
        {
            PatientId = dto.PatientId,
            DoctorId = dto.DoctorId,
            Date = dto.Date,
            TimeSlotId = dto.TimeSlotId,
            RoomId = dto.RoomId
        };

        _context.Appointments.Add(appointment);
        await _context.SaveChangesAsync();

        return Ok(appointment);
    }

    // PUT: api/appointments/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAppointment(int id, [FromBody] Appointment appointment)
    {
        if (id != appointment.Id) return BadRequest();

        _context.Entry(appointment).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Appointments.Any(e => e.Id == id))
                return NotFound();
            throw;
        }

        return NoContent();
    }

    // DELETE: api/appointments/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAppointment(int id)
    {
        var appointment = await _context.Appointments.FindAsync(id);
        if (appointment == null) return NotFound();

        _context.Appointments.Remove(appointment);
        await _context.SaveChangesAsync();

        return Ok();
    }
    
   

}