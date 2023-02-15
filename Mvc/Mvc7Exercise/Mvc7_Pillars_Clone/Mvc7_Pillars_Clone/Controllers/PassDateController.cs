using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Pillars_Clone.Controllers
{
    public class PassDateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PetShop()
        {
            //1.使用ViewData傳遞資料到View
            ViewData["Company"] = "汪星人寵物店";
            //2.使用ViewBag傳遞資料到View
            ViewBag.Address = "台北市信義區中山路";
            List<string> petsList = new List<string>
            {
                "狗","貓","鴨子"
            };


            return View(petsList);
        }
    }
}
