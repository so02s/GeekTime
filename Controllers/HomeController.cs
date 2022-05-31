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


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAdmin(Admin admin)
        {
            db.Admins.Add(admin);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }




        public async Task<IActionResult> Index()
        {
            return View(await db.Admins.ToListAsync());
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

        public IActionResult Admins()
        {
            return View();
        }
        public IActionResult Rooms()
        {
            return View();
        }
        public IActionResult Comics()
        {
            return View();
        }
        public IActionResult Events()
        {
            return View();
        }
        public IActionResult Games()
        {
            return View();
        }
        public IActionResult Price()
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
