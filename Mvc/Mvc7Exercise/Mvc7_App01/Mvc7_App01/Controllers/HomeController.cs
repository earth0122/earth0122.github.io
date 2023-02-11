using Microsoft.AspNetCore.Mvc;
using Mvc7_App01.Models;
using System.Diagnostics;

namespace Mvc7_App01.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index() 
        //{
        //    Product product = new Product
        //    {
        //        Id = 1,
        //        Name = "SSD 512GB",
        //        Price = 2500
        //    };
        //    return View(product);
        //}

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string GetName()
        {
            return "Mary";
        }
        
        public IActionResult Index()
        {
            return View("Privacy");
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