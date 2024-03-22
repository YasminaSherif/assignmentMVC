using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment.Models
{
    public class Trainees
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public string Level { get; set; }

      //  [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Departments Department { get; set; }
        public virtual ICollection<CrsResult> Crs { get; set; } = new List<CrsResult>();
    }
}
