using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Razor.Controllers
{
    public class LabsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RazorToCSharp()
        {

            return View();
        }
    }
}
