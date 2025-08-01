using Clinic_Complex_Management_System.Data;
using Clinic_Complex_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class RoomController : ControllerBase
{
    private readonly AppDbContext _context;

    public RoomController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/room
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
    {
        return await _context.Rooms.Include(r => r.Hospital).ToListAsync();
    }

    // GET: api/room/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Room>> GetRoom(int id)
    {
        var room = await _context.Rooms.Include(r => r.Hospital).FirstOrDefaultAsync(r => r.Id == id);
        if (room == null)
            return NotFound();

        return room;
    }

    // POST: api/room
    [HttpPost]
    public async Task<ActionResult<Room>> CreateRoom(Room room)
    {
        _context.Rooms.Add(room);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetRoom), new { id = room.Id }, room);
    }

    // PUT: api/room/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateRoom(int id, Room room)
    {
        if (id != room.Id)
            return BadRequest();

        _context.Entry(room).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // DELETE: api/room/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRoom(int id)
    {
        var room = await _context.Rooms.FindAsync(id);
        if (room == null)
            return NotFound();

        _context.Rooms.Remove(room);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}