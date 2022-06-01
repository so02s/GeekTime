using GeekTime.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GeekTime.Site_Data;

namespace GeekTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private GeekTimeContext db;

        public HomeController(ILogger<HomeController> logger, GeekTimeContext context)
        {
            _logger = logger;
            db = context;
        }


        public IActionResult For_admins()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Admins.ToListAsync());
        }
        public IActionResult ContactPage()
        {
            return View();
        }
        public IActionResult CreateContact()
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

        public async Task<IActionResult> Admins()
        {
            return View(await db.Admins.ToListAsync());
        }
        public IActionResult Rooms()
        {
            return View();
        }
        public IActionResult Comics()
        {
            return View();
        }
        public async Task<IActionResult> Events()
        {
            return View(await db.Events.ToListAsync());
        }
        public IActionResult Games()
        {
            return View();
        }
        public async Task<IActionResult> Rate()
        {
            return View(await db.Rates.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
