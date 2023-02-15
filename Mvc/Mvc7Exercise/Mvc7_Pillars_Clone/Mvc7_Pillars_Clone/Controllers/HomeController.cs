using Microsoft.AspNetCore.Mvc;
using Mvc7_Pillars_Clone.Models;
using System.Diagnostics;

namespace Mvc7_Pillars_Clone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Developer"] = "陳彥廷";
            
            return RedirectToAction("PetShop", "PassDate");
            //return View("~/Views/PassDate/PetShop.cshtml");
            //return View("~/Views/Shared/ShowMessage.cshtml");
            ViewData["Message"] = "Hi ...ChatGPT, 怎麼樣可以交到女友 ";
            return View("ShowMwssage");
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