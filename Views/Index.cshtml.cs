#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Celebrity_School.Data;
using Celebrity_School.Models;

namespace Celebrity_School.Views
{
    public class IndexModel : PageModel
    {
        private readonly Celebrity_School.Data.ApplicationDbContext _context;

        public IndexModel(Celebrity_School.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Courses> Courses { get;set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Course.ToListAsync();
        }
    }
}
