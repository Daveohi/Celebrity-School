using System.ComponentModel.DataAnnotations;

namespace Celebrity_School.Models
{
    public class Courses
    {
        [Key]

        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public string CourseCode { get; set; }

        public string CourseUnit { set; get; }
    }
}
