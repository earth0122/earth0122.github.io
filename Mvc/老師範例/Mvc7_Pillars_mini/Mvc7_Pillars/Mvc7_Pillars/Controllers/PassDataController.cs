using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Pillars.Controllers
{
    public class PassDataController : Controller
    {
        [ViewData]
        public string Gender { get; set; }

        [ViewData(Key = "Edu")]
        public string Education { get; set; }

        [TempData]
        public string Message { get; set; }

        public List<Employee> empsList { get; } = new List<Employee>
        {
            new Employee { Id = 10001, Name = "David", Phone = "0933-154228", Email ="david@gmail.com" },
            new Employee { Id = 10002, Name = "Mary", Phone = "0925-157886", Email ="mary@gmail.com" },
            new Employee { Id = 10003, Name = "John", Phone = "0921-335884", Email ="john@gmail.com" },
            new Employee { Id = 10004, Name = "Cindy", Phone = "0971-628322", Email ="cindy@gmail.com" },
            new Employee { Id = 10005, Name = "Rose", Phone = "0933-154228",  Email ="rose@gmail.com" }
        };

        public IActionResult Index()
        {
            return View();
        }

        //ViewData傳遞資料
        public IActionResult PassViewData()
        {
            //ViewData
            ViewData["Name"] = "Kevin";		    //儲存字串
            ViewData["Age"] = 33;               //儲存整數
            ViewData["Single"] = true;          //儲存布林值
            ViewData["Employees"] = empsList;   //儲存model集合物件

            return View();
        }

        public IActionResult ViewDataAttribute()
        {
            ViewData["Name"] = "Kevin";
            Gender = "男性";
            Education = "研究所";

            return View();
        }

        //以ViewBag傳遞資料
        public IActionResult PassViewBag()
        {
            //ViewBag
            ViewBag.Nickname = "Mary";
            ViewBag.Height = 168;
            ViewBag.Weight = 52;
            ViewBag.Married = false;
            ViewBag.EmpsList = empsList;    //儲存model集合物件

            return View();
        }

        //以Model傳遞資料
        public ActionResult PassModel()
        {
            //1.呼叫View()方法時，直接將model當成參數傳入
            return View(empsList);

            //2.將model物件指定給ViewData.Model屬性
            //ViewData.Model = empsList;
            //return View();
        }

        public IActionResult PetShop()
        {
            //1.使用ViewData傳遞資料到View
            ViewData["Company"] = "汪星人寵物店";

            //2.使用ViewBag傳遞資料到View
            ViewBag.Address = "台北市信義區松山路100號";

            //宣告一個List泛型集合,代表model資料模型
            List<string> petsList = new List<string>();
            petsList.Add("狗");
            petsList.Add("猫");
            petsList.Add("魚");
            petsList.Add("鼠");
            petsList.Add("變色龍");

            //或用
            List<string> petsList2 = new List<string>(){ "狗", "猫", "魚", "鼠", "變色龍" };
            

            //3.將petSList資料模型指派給ViewData.Model屬性, 傳遞到View
            ViewData.Model = petsList;

            return View();

            //實際上傳送model物件給View,會更常使用View(petsList)語法取代
            //return View(petsList);
        }

        public IActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "無足夠權限存取系統資料, 請連絡系統管理人員";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();

            TempData["Message"] = "禁止存取";

            return RedirectToAction("ErrorMessage", "ErrorHandler");
        }

        //傳送單筆資料
        public IActionResult StronglyTypedView()
        {
            Employee employee = new Employee
            {
                Id = 10001,
                Name = "David",
                Phone = "0933-154228",
                Email = "david@gmail.com"
            };

            return View(employee);
        }

        //以List<Employee>泛型集合傳送多筆資料
        public IActionResult StronglyTypedViewList()
        {
            return View(empsList);
        }
    }
}
