using System.ComponentModel.DataAnnotations;

namespace Celebrity_School.Models
{
    public class Grades
    {
        internal static readonly string? ReturnUrl;

        [Key]

        public int GradeId { get; set; }
        public int Grade { get; set; }


        public ICollection<Courses> Course { get; set; }


        public Students Student { get; set; }

        public int Id { get; set; }
    }
}
