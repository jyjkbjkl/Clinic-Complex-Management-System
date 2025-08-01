namespace Clinic_Complex_Management_System.DTOs
{
    public class AppointmentCreateDTO
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public int TimeSlotId { get; set; }
        public int RoomId { get; set; }
    }
}
