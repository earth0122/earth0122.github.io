using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Pillars.Controllers
{
    public class ErrorHandlerController : Controller
    {
        public IActionResult ErrorMessage()
        {
            if (!TempData.ContainsKey("ErrorMessage"))
            {
                return new EmptyResult();
            }

            TempData.Keep();  //保留全部Key
            //TempData.Keep("ErrorMessage");    //保留指定Key

            return View();
        }
    }
}
