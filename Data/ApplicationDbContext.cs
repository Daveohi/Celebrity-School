using Celebrity_School.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Celebrity_School.Data
{
    public class ApplicationDbContext:IdentityDbContext<Students>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public DbSet<Grades> Grade { get; set; }
        public DbSet<Students> Student { get; set; }
        public DbSet<Courses> Course { get; set; }
    }


}
