using CoreMvc3_App02_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoreMvc3_App02_1.Controllers
{
    //繼承Controller
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }

        //Home/Idex 端點=>請求的處理端
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index( int? id)
        {
            //TODO: 
            return View();
        }

        public IActionResult Privacy()
        {
            //TODO: 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}