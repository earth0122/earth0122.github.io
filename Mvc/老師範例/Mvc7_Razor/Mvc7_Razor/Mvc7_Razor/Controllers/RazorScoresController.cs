using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Razor.Controllers
{
    public class RazorScoresController : Controller
    {
        //學生考試成績model資料
        protected List<Student> students = new List<Student>
        {
            new Student { Id =1, Name="Joe", Chinese=88, English=95, Math=71 },
            new Student { Id =12, Name="Mary", Chinese=92, English=82, Math=60 },
            new Student { Id =23, Name="Cathy", Chinese=98, English=91, Math=94 },
            new Student { Id =34, Name="John", Chinese=63, English=85, Math=55 },
            new Student { Id =45, Name="David", Chinese=59, English=77, Math=82 }
        };


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Scores()
        {
            return View(students);
        }

        public IActionResult ScoresRazor()
        {
            //計算所有學生Total總分欄
            students.ForEach(s => s.Total = s.Chinese + s.English + s.Math);

            //找出總分最高者Id
            var topId = students.OrderByDescending(s => s.Total)
                                .Select(s => s.Id)
                                .FirstOrDefault();

            ViewData["TopId"] = topId;

            return View(students);
        }

        public IActionResult ScoresRazorPure()
        {
            return View(students);
        }
    }
}
