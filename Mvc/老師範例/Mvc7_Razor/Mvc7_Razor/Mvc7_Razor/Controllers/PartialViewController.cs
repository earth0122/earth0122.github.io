using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Razor.Controllers
{
    public class PartialViewController : Controller
    {
        public List<Card> cards;

        private readonly CardContext _context;
        public PartialViewController(CardContext context)
        {
            _context = context;

            cards = new List<Card>
                    {
                        new Card { Name = "Elon Musk", Brief="特斯拉創辦人 伊隆·馬斯克", Photo="ElonMusk.jpg", WikiUrl="https://goo.gl/46xeXx" },
                        new Card { Name = "Mark Zuckerberg", Brief="Facebook創辦人 馬克·祖伯克", Photo="MarkZuckerberg.jpg", WikiUrl="https://goo.gl/BktGGA" },
                        new Card { Name = "Steve Jobs", Brief="蘋果創辦人 史提夫·賈伯斯", Photo="SteveJobs.jpg", WikiUrl="https://goo.gl/nAiX0y" },
                        new Card { Name = "Vader", Brief="帝國元帥  維達", Photo="Vader.jpg", WikiUrl="http://bit.ly/3F5xw2w" },
                        new Card { Name = "Darth Mual", Brief="星際大戰 達斯摩", Photo="DarthMual.jpg", WikiUrl="https://goo.gl/5obLhX"},
                        new Card { Name = "White Twilek", Brief="星際大戰 女絕地武士Twilek", Photo="WhiteTwilek.jpg", WikiUrl="https://goo.gl/reKzAu" },
                        new Card { Name = "Obiwan", Brief="星際大戰 歐比旺Obiwan", Photo="Obiwan.jpg", WikiUrl="http://bit.ly/33gxdgt" },
                        new Card { Name = "Merkel", Brief="德國總理 梅克爾", Photo="Merkel.jpg", WikiUrl="http://bit.ly/33huSlv" }
                    };
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SimpleCard()
        {
            return View();
        }

        public IActionResult CardList()
        {
            return View(cards);
        }

        public async Task<IActionResult> CardListDB()
        {
            return View(await _context.Card.ToListAsync());
        }

        //View呼叫Partial View的幾種語法
        public IActionResult SeveralWays()
        {
            return View(cards);
        }


        //View傳遞ViewData到Partial View的幾種語法
        public IActionResult PassViewData2PartialView()
        {
            ViewData["Movie"] = "復仇者聯盟4";
            ViewData["Song"] = "When the party is over.";

            return View();
        }

        //View傳遞Model到Partial View的幾種語法
        public IActionResult PassModel2PartialView()
        {
            return View(cards);
        }
    }
}
