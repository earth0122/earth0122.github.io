

//加入類別檔案GlobalUsings.cs, using namespace

namespace MVC7_App01.Controllers;
public class ProductsController : Controller
{
    //基本IActionResult Index()
    public IActionResult Index()
    {
        //單筆資料傳送
        //一筆Entity
        Product product = new Product
        {
            Id = 1,
            Name = "SSD 512G",
            Price = 2500
        };
        return View(product); // Views/Products/Index.shtml
    }

    public IActionResult FindCatrgory(string category)
    {
        //ToDo: SQL 找filter 要的分類
        /*e.g.找filter SSD分類
         * 網址:https://localhost:xxx/路由/分類/編號
         * https://localhost:xxx/Product/SSD/5
         * ->Program.cs ->app.MapControllerRoute

         */
        return View();
    }

    public ProductsController()
    {
        //Respon/Request
    }
}


