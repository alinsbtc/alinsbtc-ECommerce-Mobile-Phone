using E_Commerce_Mobile_Phone.Data;
using E_Commerce_Mobile_Phone.Models;
using E_Commerce_Mobile_Phone.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_Commerce_Mobile_Phone.Controllers
{
    public class HomeController : Controller
    {
        private readonly EcAlinContext db;
        public HomeController(EcAlinContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var products = db.DbProducts.AsQueryable();
            var result = products.Select(p => new ProductVM
            {
                Id = p.Id,
                Name = p.Name,
                Avatar = p.Avatar,
                Price = p.Price,
                PriceSale = p.PriceSale,
                Img = p.Img,
            });
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

   
    }
}
