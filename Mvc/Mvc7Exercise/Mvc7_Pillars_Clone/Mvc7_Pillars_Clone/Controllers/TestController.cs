using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Pillars_Clone.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
