using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class ComicsController : Controller
    {
        private IComicsManager _comicsManager;
        public ComicsController(IComicsManager comicsManager)
        {
            _comicsManager = comicsManager;
        }
        public ViewResult ComicsPage()
        {
            var comics = _comicsManager.сomics;
            return View(comics);
        }

        [HttpPost]
        public ActionResult CreateComics(string Name, string Genre, string Room)
        {
            try
            {
                _comicsManager.AddComics(new Comics(Name, Genre, Room));
                return RedirectToAction(nameof(ComicsPage));
            }
            catch
            {
                return RedirectToAction(nameof(ComicsPage));
            }
        }
    }
}


