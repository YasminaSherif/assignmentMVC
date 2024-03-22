namespace assignment.ViewModel
{
    public class TraineeWithCourseDegreeAndStatues
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }
        public double? degree { get; set;}
        public string color { get; set; }  
        public status status { get; set; }
    }
    public enum status
    {
        passed,
        failed
    }
}
