namespace Clinic_Complex_Management_System.Models
{
   
        public class TimeSlot
        {
            public int Id { get; set; }
            public TimeSpan StartTime { get; set; }
            public TimeSpan EndTime { get; set; }

            public List<Appointment> Appointments { get; set; }
        }
    
}
