


namespace Clinic_Complex_Management_System.Models
{
   
        public class MedicalRecord
        {
            public int Id { get; set; }
            public string Diagnosis { get; set; }
            public string Treatment { get; set; }

            public int PatientId { get; set; }
            public Patient Patient { get; set; }

            public DateTime CreatedAt { get; set; }
        }
    
}
