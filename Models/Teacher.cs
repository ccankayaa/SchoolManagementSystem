using Microsoft.AspNetCore.Identity;

namespace SchoolManagementSystem.Models
{
    public class Teacher : BaseEntity
    {
        public string GraduatedFrom { get; set; }
        public short GraduatedYear { get; set; }
        public long CertificateNumber { get; set; }
        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
        public ICollection<Course> Courses { get; } = new List<Course>();
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
