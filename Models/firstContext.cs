using Microsoft.EntityFrameworkCore;

namespace assignment.Models
{
    public class firstContext : DbContext
    {
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Trainees> Trainees { get; set; }
        public DbSet<Instructors> instructors { get; set; }
        public DbSet<Courses> courses { get; set; }
        public DbSet<CrsResult> crsResult { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DGIE8P7\\SQLEXPRESS;Database=assignment;Trusted_Connection=True;TrustServerCertificate=True;");
            //base.OnConfiguring(optionsBuilder);
        }



    }
}
