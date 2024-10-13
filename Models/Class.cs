using System.ComponentModel;

namespace SchoolManagementSystem.Models
{
    public enum UserType
    {
        [Description("Admin")]
        Admin = 1,
        [Description("Teacher")]
        Teacher = 2,
        [Description("Student")]
        Student = 3
    }
}
