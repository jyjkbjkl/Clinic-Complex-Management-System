using Clinic_Complex_Management_System.Data;
using Microsoft.AspNetCore.Mvc;

namespace Clinic_Complex_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PatientsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePatient([FromBody] Patient patient)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();

            return Ok(patient);
        }
    }
}
