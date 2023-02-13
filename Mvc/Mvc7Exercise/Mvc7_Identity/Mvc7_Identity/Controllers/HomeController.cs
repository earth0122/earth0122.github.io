using Microsoft.AspNetCore.Mvc;
using Mvc7_Identity.Models;
using System.Diagnostics;

namespace Mvc7_Identity.Controllers
{
    [Authorize]   //設定權限管控 不讓匿名者瀏覽
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [AllowAnonymous]//可以讓匿名者瀏覽
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            if (User.Identity.Name.ToUpper() != "kevin@gmail.com")
            {
                return Content($"{User.Identity.Name}無權存取此Action動作方法");
            }
            return View();
        }

        [Authorize(Roles = "Admin, Supervisor")] //群組方式給權限   但群組方式要自己寫
        public IActionResult Contact()
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