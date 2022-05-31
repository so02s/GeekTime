using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class BoardGamesController : Controller
    {
        private IBoardGameManager _boardgameManager;
        public BoardGamesController(IBoardGameManager boardgameManager)
        {
            _boardgameManager = boardgameManager;
        }
        public ViewResult BoardGamePage()
        {
            var bg = _boardgameManager.boardgame;
            return View(bg);
        }

        [HttpPost]
        public ActionResult CreateBoardGame(string Name, int MaxPlayers, int Playtime, string Photo, string Rooms)
        {
            try
            {
                _boardgameManager.AddBoardGame(new BoardGame(Name, MaxPlayers, Playtime, Photo, Rooms));
                return RedirectToAction(nameof(BoardGamePage));
            }
            catch
            {
                return RedirectToAction(nameof(BoardGamePage));
            }
        }
    }
}
