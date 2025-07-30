


namespace Clinic_Complex_Management_System.Models
{
    
        public class Appointment
        {
            public int Id { get; set; }

            public int PatientId { get; set; }
            public Patient Patient { get; set; }

            public int DoctorId { get; set; }
            public Doctor Doctor { get; set; }

            public DateTime Date { get; set; }
            public int TimeSlotId { get; set; }
            public TimeSlot TimeSlot { get; set; }

            public int RoomId { get; set; }
            public Room Room { get; set; }
        }
    
}
