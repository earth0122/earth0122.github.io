using Microsoft.AspNetCore.Mvc;
using Mvc7_Identity.Models;
using System.Diagnostics;

namespace Mvc7_Identity.Controllers
{
    [Authorize]//權限管控,不能是非登入狀態(匿名者) e.g.後台畫面
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]//權限管控,可以是非登入狀態(匿名者)e.g.首頁
        public IActionResult Index()
        {
            return View();
        }
        
        //繼承[Authorize]
        public IActionResult Privacy()
        {
            //利用Identity.Name判斷權限
            if(User.Identity.Name != "kevin@gmail.com".ToUpper())
            {
                return Content($"{User.Identity.Name}無權存取此Action動作方法");
            }

            return View();
        }

        [Authorize(Roles ="Admin, Supervisor")]
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