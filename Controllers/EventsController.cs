using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class EventsController : Controller
    {
        private IEventsManager _eventManager;
        public EventsController(IEventsManager eventManager)
        {
            _eventManager = eventManager;
        }
        public ViewResult EventPage()
        {
            var events = _eventManager.Event;
            return View(events);
        }

        [HttpPost]
        public ActionResult CreateEvent(string Name, string Image, string Describthion, string AdminID)
        {
            try
            {
                _eventManager.AddEvent(new Events(Name, Image, Describthion, AdminID));
                return RedirectToAction(nameof(EventPage));
            }
            catch
            {
                return RedirectToAction(nameof(EventPage));
            }
        }
    }
}


