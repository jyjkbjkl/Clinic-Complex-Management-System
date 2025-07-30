namespace Clinic_Complex_Management_System.Models
{
    
        public class Department
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public ICollection<Doctor> Doctors { get; set; }
        }
    
}
