using E_Commerce_Mobile_Phone.Data;
using E_Commerce_Mobile_Phone.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Mobile_Phone.Controllers
{
    public class ShopController : Controller
    {
        private readonly EcAlinContext db ;
        public ShopController(EcAlinContext context) {
            db = context;
        }

        public IActionResult Index()
        {
            var userId = HttpContext.Session.GetInt32("Id");
            var fullname = HttpContext.Session.GetString("Fullname");

            ViewBag.UserId = userId;
            ViewBag.Fullname = fullname;
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

    }
}
