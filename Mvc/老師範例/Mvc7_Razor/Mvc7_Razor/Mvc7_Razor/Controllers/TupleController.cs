using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Razor.Controllers
{
    public class TupleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TupleTest()
        {
            //1.形式一
            var cars = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(1, "BMW"),
                new Tuple<int, string>(2, "BENZ"),
                new Tuple<int, string>(3, "Lexus"),
            };


            ViewBag.Cars = cars;

            //2.形式二
            var t1 = (Id: 1, Caption: "Gogoro 3 plus", Description: "漿果紅。新色上市", Image: "gogoro_red.jpg", Video: "");
            var t2 = (Id: 1, Caption: "Gogoro 2 Rumbler", Description: "閃爆街頭。智慧雙輪", Image: "gogoro_black.jpg", Video: "");
            var t3 = (Id: 1, Caption: "Gogoro Network", Description: "最智慧、最穩定", Image: "gogoro_battery.jpg", Video: "gogoro_battery.mp4");
            var t4 = (Id: 1, Caption: "Future Now", Description: "衝出未來。新車上市", Image: "gogoro_future.jpg", Video: "gogoro_future.mp4");

            var products = new List<(int Id, string Caption, string Description, string Image, string Video)>();
            products.Add(t1);
            products.Add(t2);
            products.Add(t3);
            products.Add(t4);

            //3.形式三
            (int Id, string Caption, string Description, string Image, string Video) tuple1 = (1, "Gogoro 3 plus", "漿果紅。新色上市", "gogoro_red.jpg", "");
            (int Id, string Caption, string Description, string Image, string Video) tuple2 = (2, "Gogoro 2 Rumbler", "閃爆街頭。智慧雙輪", "gogoro_black.jpg", "");
            (int Id, string Caption, string Description, string Image, string Video) tuple3 = (3, "Gogoro Network", "最智慧、最穩定", "gogoro_battery.jpg", "gogoro_battery.mp4");
            (int Id, string Caption, string Description, string Image, string Video) tuple4 = (4, "Future Now", "衝出未來。新車上市", "gogoro_future.jpg", "gogoro_future.mp4");

            var productList = new List<(int Id, string Caption, string Description, string Image, string Video)>();
            productList.Add(tuple1);
            productList.Add(tuple2);
            productList.Add(tuple3);
            productList.Add(tuple4);

            return View(productList);
        }
    }
}
