using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Razor.Controllers
{
    public class VcController : Controller
    {
        protected List<Student> students { get; } = new List<Student>
        {
            new Student { Id =1, Name="Joe", Chinese=88, English=95, Math=71 },
            new Student { Id =12, Name="Mary", Chinese=92, English=82, Math=60 },
            new Student { Id =23, Name="Cathy", Chinese=98, English=91, Math=94 },
            new Student { Id =34, Name="John", Chinese=63, English=85, Math=55 },
            new Student { Id =45, Name="David", Chinese=59, English=77, Math=82 }
        };

        public List<Card> cards { get; } = new List<Card>
        {
            new Card { Name = "Elon Musk", Brief="特斯拉創辦人 伊隆·馬斯克", Photo="ElonMusk.jpg", WikiUrl="https://goo.gl/46xeXx" },
            new Card { Name = "Mark Zuckerberg", Brief="Facebook創辦人 馬克·祖伯克", Photo="MarkZuckerberg.jpg", WikiUrl="https://goo.gl/BktGGA" },
            new Card { Name = "Steve Jobs", Brief="蘋果創辦人 史提夫·賈伯斯", Photo="SteveJobs.jpg", WikiUrl="https://goo.gl/nAiX0y" },
            new Card { Name = "Vader", Brief="帝國元帥  維達", Photo="Vader.jpg", WikiUrl="https://en.wikipedia.org/wiki/Darth_Vader" },
            new Card { Name = "Darth Mual", Brief="星際大戰 達斯摩", Photo="DarthMual.jpg", WikiUrl="https://goo.gl/5obLhX"},
            new Card { Name = "White Twilek", Brief="星際大戰 女絕地武士Twilek", Photo="WhiteTwilek.jpg", WikiUrl="https://goo.gl/reKzAu" },
            new Card { Name = "White Twilek", Brief="星際大戰 歐比旺Obiwan", Photo="Obiwan.jpg", WikiUrl="http://bit.ly/33gxdgt" },
            new Card { Name = "White Twilek", Brief="德國總理 梅克爾", Photo="Merkel.jpg", WikiUrl="http://bit.ly/33huSlv" },
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ScoreViewComponents()
        {
            return View(students);
        }

        //在Partial View呼叫使用View Components
        public IActionResult PvCallVc()
        {
            return View(cards);
        }
    }
}
