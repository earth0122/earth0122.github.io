using Microsoft.AspNetCore.Mvc;
using MVC7_App01.Models;
using System.Diagnostics;

namespace MVC7_App01.Controllers
{
    public class HomeController : Controller
    {
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
            return View();//預設 -> "Index" -> Index.cshtml
            //return View("Privacy"); //->Privacy.cshtml
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