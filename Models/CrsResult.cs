namespace assignment.Models
{
    public class CrsResult
    {
        public int Id { get; set; }
        public double? Grade { get; set; }

        public int CourseId { get; set; }
        public virtual Courses Course { get; set; }

        public int TraineeId { get; set; }
        public virtual Trainees Trainee { get; set; }

    }
}
