using Celebrity_School.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Celebrity_School.Controllers
{

    [Authorize]
    public class Gradecontroller : Controller

    {
        private
        Grades student = new()
        {


            Grade = StudentUser.Grade,

            Id = StudentUser.Id,



        };



        public IActionResult Index()
        {
            return View();
        }
    }
}
