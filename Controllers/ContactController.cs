using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class ContactController : Controller
    {
        private IContactManager _contactManager;
        public ContactController(IContactManager contactManager)
        {
            _contactManager = contactManager;
        }
        public async Task<IActionResult> ContactPage()
        {
            var cg = await _contactManager.GetAll();
            return View(cg);
        }
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(Contact contact)
        {
            await _contactManager.AddContact(contact.Name, contact.TelNumber, contact.Mail, contact.Post);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteContact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteContact(Contact contact)
        {
            await _contactManager.DeleteContact(contact.ID);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("contacts")]
        public Task<IList<Contact>> GetAll() => _contactManager.GetAll();

        [HttpPut]
        [Route("contacts")]
        public Task AddContact([FromBody] Contact contact) => _contactManager.AddContact(contact.Name, contact.TelNumber, contact.Mail, contact.Post);

        [HttpDelete]
        [Route("contacts/{id}")]
        public Task DeleteContact(int id) => _contactManager.DeleteContact(id);
    }
}