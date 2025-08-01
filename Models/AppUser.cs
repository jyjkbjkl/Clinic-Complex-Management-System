using Microsoft.AspNetCore.Identity;

namespace ClinicSystem.Models
{
    public class AppUser : IdentityUser
    {
        // ممكن تضيف بيانات زيادة زي الاسم الكامل أو التخصص مثلاً
        public string FullName { get; set; }
        public string Role { get; set; } // optional: للتسهيل مع الـ seed
    }
}