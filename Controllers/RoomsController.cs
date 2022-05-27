using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class RoomsController : Controller
    {
        private IRoomsManager _roomsManager;
        public RoomsController(IRoomsManager roomsManager)
        {
            _roomsManager = roomsManager;
        }
        public ViewResult RoomsPage()
        {
            var room = _roomsManager.rooms;
            return View(room);
        }

    }
}
