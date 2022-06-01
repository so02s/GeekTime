using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventManager _eventManager;
        public EventController(IEventManager eventManager)
        {
            _eventManager = eventManager;
        }

        public async Task<IActionResult> EventPage()
        {
            var _events = await _eventManager.GetAll();
            return View(_events);
        }


        public IActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEvent(Event _event)
        {
            await _eventManager.DeleteEvent(_event.ID);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent(Event _event)
        {
            await _eventManager.AddEvent(_event.Name, _event.Image, _event.Describtion, _event.AdminID);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteEvent()
        {
            return View();
        }


        [HttpGet]
        [Route("events")]
        public Task<IList<Event>> GetAll() => _eventManager.GetAll();

        [HttpPut]
        [Route("events")]
        public Task AddEvent([FromBody] Event _event) => _eventManager.AddEvent(_event.Name, _event.Image, _event.Describtion, _event.AdminID);

        [HttpDelete]
        [Route("events/{id}")]
        public Task DeleteEvent(int id) => _eventManager.DeleteEvent(id);
    }
}




