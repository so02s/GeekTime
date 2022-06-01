using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class RoomController : Controller
    {
        private IRoomManager _roomManager;
        public RoomController(IRoomManager roomManager)
        {
            _roomManager = roomManager;
        }
        public async Task<IActionResult> RoomPage()
        {
            var cg = await _roomManager.GetAll();
            return View(cg);
        }

        public IActionResult CreateRoom()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRoom(Room room)
        {
            await _roomManager.AddRoom(room.Name, room.Image, room.EventId, room.RateID, room.TimetableRentID);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteRoom()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteRoom(Room room)
        {
            await _roomManager.DeleteRoom(room.ID);
            return RedirectToAction("Index");
        }


        [HttpGet]
        [Route("rooms")]
        public Task<IList<Room>> GetAll() => _roomManager.GetAll();

        [HttpPut]
        [Route("rooms")]
        public Task AddRoom([FromBody] Room room) => _roomManager.AddRoom(room.Name, room.Image, room.EventId, room.RateID, room.TimetableRentID);

        [HttpDelete]
        [Route("rooms/{id}")]
        public Task DeleteRoom(int id) => _roomManager.DeleteRoom(id);

    }
}
