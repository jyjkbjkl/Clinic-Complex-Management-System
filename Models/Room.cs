namespace Clinic_Complex_Management_System.Models
{
   
        public class Room
        {
            public int Id { get; set; }
            public string RoomNumber { get; set; }

            public int HospitalId { get; set; }
            public Hospital Hospital { get; set; }

            public List<Appointment> Appointments { get; set; }
        }
    
}
