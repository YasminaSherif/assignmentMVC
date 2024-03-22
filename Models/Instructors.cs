using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment.Models
{
    public class Instructors
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public string Image { get; set; }

        public int DepartmentsId { get; set; }
        public virtual Departments Departments { get; set; }

        public int CoursesId { get; set; }
        public virtual Courses Courses { get; set; }


    }
}
