using E_Commerce_Mobile_Phone.Data;
using E_Commerce_Mobile_Phone.Models;
using E_Commerce_Mobile_Phone.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace E_Commerce_Mobile_Phone.Controllers
{
    public class CustomerController : Controller
    {
        private readonly EcAlinContext _db;

        public CustomerController(EcAlinContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var userId = HttpContext.Session.GetInt32("Id");
            var fullname = HttpContext.Session.GetString("Fullname");

            ViewBag.UserId = userId;
            ViewBag.Fullname = fullname;

            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterVM _user)
        {
            if (ModelState.IsValid)
            {
                var check = _db.DbCustomers.FirstOrDefault(s => s.Email == _user.Email);
                if (check == null)
                {
                    // Convert Gender from byte? to byte before assigning it to newCustomer
                    byte genderValue = _user.Gender ?? 0; // Default value if Gender is null
                                                          // Create a new DbCustomer object from data in RegisterVM
                    var newCustomer = new DbCustomer
                    {
                        Fullname = _user.Fullname,
                        Username = _user.Username,
                        Password = GetMD5(_user.Password),
                        Gender = genderValue,
                        Birthday = _user.Birthday,
                        Address = _user.Address,
                        Phone = _user.Phone,
                        Email = _user.Email,
                        Created = DateTime.Now,
                        Trash = false,
                        Access = true,
                        Status = true
                    };

                    _db.DbCustomers.Add(newCustomer);
                    _db.SaveChanges();
                    return RedirectToAction("Index", "Shop"); // Redirect to Shop's Index action after successful registration
                }
                else
                {
                    ViewBag.error = "Email already exists";
                    return View(); // Return to the registration view with an error message
                }
            }
            return View(); // Return to the registration view if model state is not valid
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string username, string password)
        {
            if (ModelState.IsValid)
            {
                // Hash the password entered by the user
                string hashedPassword = GetMD5(password);

                // Check if a user with the provided username and hashed password exists in the database
                var user = _db.DbCustomers.FirstOrDefault(s => s.Username == username && s.Password == hashedPassword);

                if (user != null)
                {
                    // Set session variables after successful login
                    HttpContext.Session.SetInt32("Id", user.Id);
                    HttpContext.Session.SetString("Fullname", user.Fullname);
                    HttpContext.Session.SetString("Email", user.Email);

                    // Authentication successful, redirect the user to the home page or any other appropriate page
                    // For now, let's assume it's the Shop's Index page
                    return RedirectToAction("Index", "Shop");
                }
                else
                {
                    // Authentication failed, set an error message
                    ViewBag.Error = "Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.";
                }
            }

            // If model state is not valid or authentication failed, return to the login view
            return View();
        }
        [HttpGet]
        public IActionResult Logout()
        {
            // Clear session values
            HttpContext.Session.Remove("Id");
            HttpContext.Session.Remove("Fullname");
            HttpContext.Session.Remove("Email");

            // Redirect to the login page or any other appropriate page
            return RedirectToAction("Login", "Customer");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogoutPost()
        {
            // Clear session values
            HttpContext.Session.Remove("Id");
            HttpContext.Session.Remove("Fullname");
            HttpContext.Session.Remove("Email");

            // Redirect to the login page or any other appropriate page
            return RedirectToAction("Login", "Customer");
        }





        public static string GetMD5(string str)
        {
            using (var md5 = MD5.Create())
            {
                var inputBytes = Encoding.ASCII.GetBytes(str);
                var hashBytes = md5.ComputeHash(inputBytes);

                var sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
