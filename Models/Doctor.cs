namespace Clinic_Complex_Management_System.Models
{
   
    
        public class Doctor
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string PhoneNumber { get; set; }

            public int SpecializationId { get; set; }
            public Specialization Specialization { get; set; }

            public int HospitalId { get; set; }
            public Hospital Hospital { get; set; }

            public List<Appointment> Appointments { get; set; }
        }
    
}
