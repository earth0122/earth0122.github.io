using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Pillars.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();

            //return View("Views/Home/Index.cshtml");
            //return View("Views/Results/Index.cshtml");

            //return View("~/Views/Home/Index.cshtml");
            //return View("~/Views/Results/Index.cshtml");
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Arbitrary()
        {
            return View("~/Views/Common/Happy.cshtml");
        }

        public ViewResult ShowMessage()
        {
            return View("Massage"); //指定錯誤的檢視名稱

            //return View("Message");  //這是正確名稱
        }
    }
}
