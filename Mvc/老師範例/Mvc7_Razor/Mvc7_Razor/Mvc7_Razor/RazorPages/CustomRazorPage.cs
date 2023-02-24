
using Microsoft.AspNetCore.Mvc.Razor;

namespace Mvc7_Razor.RazorPages
{
    public abstract class CustomRazorPage<TModel> : RazorPage<TModel>
    {
        public string AppVersion { get; } = "ASP.NET Core 7";

        public string GetBookName()
        {
            return "ASP.NET Core 7 MVC範例教學實戰";
        }
    }
}
