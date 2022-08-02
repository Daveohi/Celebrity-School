using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Celebrity_School.Models
{
    public class Students: IdentityUser
    {
       
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DOB { get; set; }

        public string Sex { get; set; }
    }
   
}

