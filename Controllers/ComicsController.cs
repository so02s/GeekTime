using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class ComicController : Controller
    {
        private IComicManager _comicManager;
        public ComicController(IComicManager comicManager)
        {
            _comicManager = comicManager;
        }
        public async Task<IActionResult> ComicPage()
        {
            var comics = await _comicManager.GetAll();
            return View(comics);
        }

        public IActionResult CreateComic()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateComic(Comic comic)
        {
            await _comicManager.AddComic(comic.Name, comic.Genre, comic.RoomID);
            return RedirectToAction(nameof(ComicPage));
        }
        public IActionResult DeleteComic()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteComic(Comic comic)
        {
            await _comicManager.DeleteComic(comic.ID);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Comics")]
        public Task<IList<Comic>> GetAll() => _comicManager.GetAll();

        [HttpPut]
        [Route("Comics")]
        public Task AddAdmin([FromBody] Comic comic) => _comicManager.AddComic(comic.Name, comic.Genre, comic.RoomID);

        [HttpDelete]
        [Route("Comics/{id}")]
        public Task DeleteAdmin(int id) => _comicManager.DeleteComic(id);
    }
}


