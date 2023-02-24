using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Razor.ViewComponents
{
    public class PriorityListViewComponent : ViewComponent
    {
        public PriorityListViewComponent()
        {
            
        }

        //InvokeAsync()和Invoke()方法只能二選一public公開,不能同時存在

        public async Task<IViewComponentResult> InvokeAsync(List<Student> students)
        {
            return View(students);
        }

        //public IViewComponentResult Invoke(List<Student> students)
        //{
        //    return View(students);
        //}
    }
}