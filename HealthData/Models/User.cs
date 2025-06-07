using Microsoft.EntityFrameworkCore;

namespace HealthData.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string DoctorNumber { get; set; }
        public string Status { get; set; }   // Напр. "Active", "Inactive", "Locked"
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

        public Role Role { get; set; }
    }
}
