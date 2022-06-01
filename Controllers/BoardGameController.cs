using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class BoardGameController : Controller
    {

        private readonly IBoardGameManager _boardGameManager;
        public BoardGameController(IBoardGameManager boardGamesManager)
        {
            _boardGameManager = boardGamesManager;
        }

        public async Task<IActionResult> BoardGamePage()
        {
            var boardGames = await _boardGameManager.GetAll();
            return View(boardGames);
        }


        public IActionResult CreateBoardGame()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBoardGame(BoardGame boardGame)
        {
            await _boardGameManager.DeleteBoardGame(boardGame.ID);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateBoardGame(BoardGame boardGame)
        {
            await _boardGameManager.AddBoardGame(boardGame.Name, boardGame.MaxPlayers, boardGame.Playtime, boardGame.Photo, boardGame.RoomID);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteBoardGame()
        {
            return View();
        }


        [HttpGet]
        [Route("BoardGames")]
        public Task<IList<BoardGame>> GetAll() => _boardGameManager.GetAll();

        [HttpPut]
        [Route("BoardGames")]
        public Task AddBoardGame([FromBody] BoardGame boardGame) => _boardGameManager.AddBoardGame(boardGame.Name, boardGame.MaxPlayers, boardGame.Playtime, boardGame.Photo, boardGame.RoomID);

        [HttpDelete]
        [Route("BoardGames/{id}")]
        public Task DeleteBoardGame(int id) => _boardGameManager.DeleteBoardGame(id);

    }
}
