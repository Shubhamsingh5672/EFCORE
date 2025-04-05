using System.ComponentModel.DataAnnotations;

namespace codeFirst.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public int CourseDuration { get; set;}

        public decimal CourseFees { get; set;}
    }
}
