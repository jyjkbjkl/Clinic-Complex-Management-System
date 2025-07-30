namespace Clinic_Complex_Management_System.Models
{
   
        public class Hospital
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }

            public List<Doctor> Doctors { get; set; }
            public List<Nurse> Nurses { get; set; }
            public List<Room> Rooms { get; set; }
        }
 }
