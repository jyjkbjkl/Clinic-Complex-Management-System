using Microsoft.EntityFrameworkCore;
using Clinic_Complex_Management_System.Data;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class DepartmentsController : ControllerBase
{
    private readonly AppDbContext _context;

    public DepartmentsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
    {
        return await _context.Departments.Include(d => d.Hospital).ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Department>> CreateDepartment(Department department)
    {
        _context.Departments.Add(department);
        await _context.SaveChangesAsync();
        return Ok(department);
    }
}