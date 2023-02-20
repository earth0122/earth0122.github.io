using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Boostrap_Clone.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Altis360()
        {
            return View();
        }
    }
}
