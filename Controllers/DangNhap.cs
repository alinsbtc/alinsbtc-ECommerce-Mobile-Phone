using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using E_Commerce_Mobile_Phone.Data;
using E_Commerce_Mobile_Phone.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Mobile_Phone.Controllers
{
    public class DangNhapController : Controller
    {
        private readonly EcAlinContext db;
        public DangNhapController(EcAlinContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Redirect to home page if user is already logged in
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(DangNhap model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = db.DbCustomers.FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);

            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username),
                    // Add more claims if needed
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    // Configure additional properties if needed
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

              

                return RedirectToAction("Index", "Home"); // Redirect to home or a secure page
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(model);
        }
    }
}
