using System.ComponentModel.DataAnnotations;

namespace Celebrity_School.Models
{
    public class StudentUser
    {
        internal static readonly int Grade;

        [Required, EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password), Required]
        public string Password { get; set; }

        public string UserName { get; set; }

        [Required, MinLength(2, ErrorMessage = "Minimium length is 2")]
        public string FirstName { get; set; }

        [Required, MinLength(2, ErrorMessage = "Minimium length is 2")]
        public string LastName { get; set; }

        public string DOB { get; set; }

        public string Sex { get; set; }
        public static int Id { get; internal set; }

        public StudentUser()
        {

       
        }
        public StudentUser(Students student)
        {
            Email = student.Email;
            UserName = student.UserName;
            FirstName = student.FirstName;
            LastName = student.LastName;
            DOB = student.DOB;
            Sex = student.Sex;
            Password = student.PasswordHash;
        
            

        }
    }
}

