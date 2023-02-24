using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Pillars.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }

        public IActionResult ProductInfo()
        {
            return View();
        }

        public IActionResult getStocks()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();

            //return View("Index");
            //return View("./Index");   //1.以./表示目前控制器名稱目錄

            //return View("../Home/Privacy");   //2.相對路徑表示法

            //3.以應用程式根目錄為基準的[絕對路徑表示法]
            //return View("Views/Products/Index.cshtml");
            //return View("/Views/Products/Index.cshtml");
            //return View("~/Views/Products/Index.cshtml");
        }
    }
}
