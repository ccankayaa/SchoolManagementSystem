namespace SchoolManagementSystem.Models
{
    public class Course:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Teacher> Teachers { get; } = [];
        public List<Student> Students { get; } = [];
    }
}
