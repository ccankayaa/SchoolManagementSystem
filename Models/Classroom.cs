namespace SchoolManagementSystem.Models
{
    public class Classroom : BaseEntity
    {
        public string? Name { get; set; }
        public short Capacity { get; set; }
        public short Floor { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public ICollection<Student> Students { get; } = new List<Student>();
    }
}
