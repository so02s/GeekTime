using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class AdminController : Controller
    {
        private IAdminManager _adminManager;
        public AdminController(IAdminManager adminManager)
        {
            _adminManager = adminManager;
        }
        public ViewResult AdminPage()
        {
            var students = _adminManager.admin;
            return View(students);
        }
        public ViewResult CreateAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string Name, string Events, string Image)
        {
            try
            {
                _adminManager.AddAdmin(new Admin(Name, Events, Image));
                return RedirectToAction(nameof(AdminPage));
            }
            catch
            {
                return RedirectToAction(nameof(AdminPage));
            }
        }
    }
}

