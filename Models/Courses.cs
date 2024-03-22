namespace assignment.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Degree { get; set; }
        public double MinDegree { get; set; }

        public int DepartmentId { get; set; }
        public virtual Departments Department { get; set; }

        public virtual ICollection<Instructors> Instructors { get; set; } = new List<Instructors>();
        public virtual ICollection<CrsResult> CrsResults { get; set; } = new List<CrsResult>();


    }
}
