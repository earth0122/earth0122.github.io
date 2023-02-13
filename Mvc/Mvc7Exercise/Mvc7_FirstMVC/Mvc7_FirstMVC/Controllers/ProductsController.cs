using Microsoft.AspNetCore.Mvc;
using Mvc7_FirstMVC.Models;

namespace Mvc7_FirstMVC.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product
            {
                Id = 1,
                Name = "SSD 512GB",
                Price = 2500
            };
            return View();
        }
    }
}
