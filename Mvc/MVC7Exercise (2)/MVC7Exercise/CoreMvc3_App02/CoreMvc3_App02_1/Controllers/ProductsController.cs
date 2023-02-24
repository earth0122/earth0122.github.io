
//原:
//using CoreMvc3_App02_1.Models;
//using Microsoft.AspNetCore.Mvc;
//namespace CoreMvc3_App02_1.Controllers { }

//加入類別 GlobalUsings.cs
//using,化簡
namespace CoreMvc3_App02_1.Controllers;


public class ProductsController : Controller
{
    public IActionResult Index()
    {
        Product product = new Product
        {
            Id = 1,
            Name = "SSD 512G",
            Price = 2500
        };

        return View(product);
    }
}