using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class ConsoleGamesController : Controller
    {
        private IConsoleGameManager _consolegameManager;
        public ConsoleGamesController(IConsoleGameManager consolegameManager)
        {
            _consolegameManager = consolegameManager;
        }
        public ViewResult ConsoleGamePage()
        {
            var cg = _consolegameManager.consolegame;
            return View(cg);
        }

        [HttpPost]
        public ActionResult CreateConsoleGame(string Name, int MaxPlayers, string WhatConsole, int Rooms)
        {
            try
            {
                _consolegameManager.AddConsoleGame(new ConsoleGames(Name, MaxPlayers, WhatConsole, Rooms));
                return RedirectToAction(nameof(ConsoleGamePage));
            }
            catch
            {
                return RedirectToAction(nameof(ConsoleGamePage));
            }
        }
    }
}
