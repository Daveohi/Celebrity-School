using System.ComponentModel.DataAnnotations;

namespace Celebrity_School.Models
{
    public class LogIn
    {
        public string Email { get; set; }

        [DataType(DataType.Password), Required]
        public string Password { get; set; }
        public string? ReturnUrl { get; set; }


        
       

    }

}
