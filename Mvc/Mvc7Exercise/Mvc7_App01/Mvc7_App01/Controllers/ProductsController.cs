using Microsoft.AspNetCore.Mvc;
using Mvc7_App01.Models;

namespace Mvc7_App01.Controllers
{
    public class ProductsController : Controller
    {
        //public ProductsController()
        //{
        //    this.Response
        //}
        public IActionResult Index()
        {
            Product product = new Product
            {
                Id = 1,
                Name = "SSD 512GB",
                Price = 2500
            };
            return View(product);
        }
    }
}
