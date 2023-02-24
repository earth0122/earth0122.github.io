﻿using Microsoft.AspNetCore.Mvc;
using Mvc7_Pillars.Models;
using System.Diagnostics;

namespace Mvc7_Pillars.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();

            //return View("Views/Home/Index.cshtml");
            //return View("Views/Results/Index.cshtml");
            //return View("~/Views/Home/Index.cshtml");
            //return View("~/Views/Results/Index.cshtml");
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}