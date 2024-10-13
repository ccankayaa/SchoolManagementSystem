using Microsoft.AspNetCore.Identity;

namespace SchoolManagementSystem.Models
{
    public class Student:BaseEntity
    {
        public ICollection<Course> Courses { get; } = new List<Course>();
        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
