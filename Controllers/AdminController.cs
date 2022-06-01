using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace GeekTime.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminManager _adminManager;
        public AdminController(IAdminManager adminManager)
        {
            _adminManager = adminManager;
        }

        public async Task<IActionResult> AdminPage()
        {
            var admins = await _adminManager.GetAll();
            return View(admins);
        }


        public IActionResult CreateAdmin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAdmin(Admin admin)
        {
            await _adminManager.DeleteAdmin(admin.ID);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdmin(Admin admin, IFormFile uploadImage)
        {
            if (ModelState.IsValid && uploadImage != null)
            {
                using (var ms = new MemoryStream())
                {
                    uploadImage.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    admin.Image = fileBytes;
                }
                await _adminManager.AddAdmin(admin.Name, admin.Events, admin.Image);
                return RedirectToAction("Index");
            }
            else { return View(); }
        }
        public IActionResult DeleteAdmin()
        {
            return View();
        }

        [HttpGet]
        [Route("admins")]
        public Task<IList<Admin>> GetAll() => _adminManager.GetAll();

        [HttpPut]
        [Route("admins")]
        public Task AddAdmin([FromBody] Admin admin) => _adminManager.AddAdmin(admin.Name, admin.Events, admin.Image);

        [HttpDelete]
        [Route("admins/{id}")]
        public Task DeleteAdmin(int id) => _adminManager.DeleteAdmin(id);
    }
}

