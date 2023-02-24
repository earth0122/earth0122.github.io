
using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Razor.ViewComponents
{
    public class CardListViewComponent : ViewComponent
    {
        public CardListViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync(List<Card> data)
        {
            return View(data);
        }
    }
}
