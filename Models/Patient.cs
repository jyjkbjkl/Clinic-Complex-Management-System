﻿namespace Clinic_Complex_Management_System.Models
{
    
    
        public class Patient
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Phone { get; set; }
            public string NationalId { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Gender { get; set; }
            public string? Address { get; set; }
        }
    }
