using Microsoft.EntityFrameworkCore;

namespace codeFirst.Models
{
    public class CourseContext: DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public CourseContext(DbContextOptions<CourseContext> options):base (options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=LTIN617499; database=CodeFirst;integrated security=true;trustservercertificate=true;");
        }
    }
}
