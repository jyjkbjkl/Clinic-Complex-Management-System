using Clinic_Complex_Management_System;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicSystem.Models
{
    public class Prescription
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateIssued { get; set; }

        [Required]
        public string MedicationDetails { get; set; }  // تفاصيل الأدوية

        // علاقة مع الطبيب
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }

        // علاقة مع المريض
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        // علاقة مع الزيارة أو الكشف (اختياري لو هنعمل زيارة)
        // public int? AppointmentId { get; set; }
        // public Appointment Appointment { get; set; }
    }
}