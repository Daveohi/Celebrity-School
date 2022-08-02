using Celebrity_School.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Celebrity_School.Controllers
    
{
   [ Authorize ]

    public class AccountController : Controller
    {
        private readonly UserManager<Students> _userManager;
        private readonly SignInManager<Students> _signInManager;



        public AccountController(UserManager<Students> userManager, SignInManager<Students> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();

        }

        [AllowAnonymous]
        public IActionResult Register() => View();


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(StudentUser studentUser)
        {
            if (ModelState.IsValid)
            {
                Students student = new()
                {
                    Email = studentUser.Email,

                    FirstName = studentUser.FirstName,
    
                    LastName = studentUser.LastName,
                   
                    UserName = studentUser.UserName,

                    Sex = studentUser.Sex,

                   DOB = studentUser.DOB,

                };

                IdentityResult result = await _userManager.CreateAsync(student, studentUser.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("LogIn");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(studentUser);
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            LogIn login = new LogIn

            {
                ReturnUrl = returnUrl

            };

            return View(login);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(LogIn logIn)
        {
            if (ModelState.IsValid)
            {
                Students student = await _userManager.FindByEmailAsync(logIn.Email);
                if (student != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager
                        .PasswordSignInAsync(student, logIn.Password, false, false);
                    if (result.Succeeded)
                    {
                        return Redirect(logIn.ReturnUrl ?? "/");
                    }
                    ModelState.AddModelError("", "Incorrect Password,TRY AGAIN! ");
                }
            }
            return View(logIn);
        }
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            HttpContext.Session.Clear();
            await _signInManager.SignOutAsync();

            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                // This needs to be a redirect so that the browser performs a new
                // request and the identity for the user gets updated.
                return Redirect("/");
            }

        }

    }
}
