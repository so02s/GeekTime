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
        private IContactsManager _contactManager;
        public ContactController(IContactsManager contactManager)
        {
            _contactManager = contactManager;
        }
        public ViewResult ContactPage()
        {
            var contacts = _contactManager.Person;
            return View(contacts);
        }
        public ViewResult CreateContacts()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateContacts(string Name, long TelNumber, string Mail, string Post)
        {
            try
            {
                _contactManager.AddPerson(new Contacts(Name, Convert.ToInt32(TelNumber), Mail, Post));
                return RedirectToAction(nameof(ContactPage));
            }
            catch
            {
                return RedirectToAction(nameof(ContactPage));
            }
        }
    }
}