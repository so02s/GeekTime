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
        public async Task<IActionResult> ConsoleGamePage()
        {
            var cg = await _consolegameManager.GetAll();
            return View(cg);
        }

        public IActionResult CreateConsoleGame()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateConsoleGame(ConsoleGame consoleGame)
        {
            await _consolegameManager.AddConsoleGame(consoleGame.Name, consoleGame.MaxPlayers, consoleGame.WhatConsole, consoleGame.Photo, consoleGame.RoomID);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteConsoleGame()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConsoleGame(ConsoleGame consoleGame)
        {
            await _consolegameManager.DeleteConsoleGame(consoleGame.ID);
            return RedirectToAction("Index");
        }


        [HttpGet]
        [Route("consoleGames")]
        public Task<IList<ConsoleGame>> GetAll() => _consolegameManager.GetAll();

        [HttpPut]
        [Route("consoleGames")]
        public Task AddConsoleGame([FromBody] ConsoleGame consoleGame) => _consolegameManager.AddConsoleGame(consoleGame.Name, consoleGame.MaxPlayers, consoleGame.WhatConsole, consoleGame.Photo, consoleGame.RoomID);

        [HttpDelete]
        [Route("consoleGames/{id}")]
        public Task DeleteConsoleGame(int id) => _consolegameManager.DeleteConsoleGame(id);
    }
}
