using Clinic_Complex_Management_System.Data;
using Clinic_Complex_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinic_Complex_Management_System
{
    
    [ApiController]
    [Route("api/[controller]")]
    
    public class HospitalController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HospitalController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var hospitals = _context.Hospitals.ToList();
            return Ok(hospitals);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var hospital = _context.Hospitals.Find(id);
            if (hospital == null) return NotFound();
            return Ok(hospital);
        }

        [HttpPost]
        public IActionResult Create(Hospital hospital)
        {
            _context.Hospitals.Add(hospital);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = hospital.Id }, hospital);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Hospital hospital)
        {
            var existing = _context.Hospitals.Find(id);
            if (existing == null) return NotFound();

            existing.Name = hospital.Name;
            existing.Address = hospital.Address;
            existing.Phone = hospital.Phone;

            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var hospital = _context.Hospitals.Find(id);
            if (hospital == null) return NotFound();

            _context.Hospitals.Remove(hospital);
            _context.SaveChanges();
            return NoContent();
        }
    }
}