using GeekTime.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Controllers
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
        }
        public IActionResult AdminPage()
        {
            return View();
        }
        public IActionResult CreateAdmin()
        {
            return View();
        }
        public IActionResult ContactPage()
        {
            return View();
        }
        public IActionResult CreateContact()
        {
            return View();
        }
        public IActionResult EventsPage()
        {
            return View();
        }
        public IActionResult CreateEvent()
        {
            return View();
        }
        public IActionResult PostsPage()
        {
            return View();
        }
        public IActionResult CreatePost()
        {
            return View();
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
