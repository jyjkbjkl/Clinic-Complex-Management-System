namespace Clinic_Complex_Management_System.Models
{
   
        public class Clinic
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int HospitalId { get; set; }

            
            public Hospital Hospital { get; set; }
            public ICollection<Doctor> Doctors { get; set; }
        }
    
}
