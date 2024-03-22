namespace assignment.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }

        public virtual ICollection<Trainees> Trainees { get; set; }=new List<Trainees>();
        public virtual ICollection<Courses> Courses { get; set; }=new List<Courses>();
        public virtual ICollection<Instructors> Instructors { get; set; }=new List<Instructors>();

    }
}
