using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class TimetableRentController : Controller
    {
        private ITimetableRentManager _timetableRentManager;
        public TimetableRentController(ITimetableRentManager timetableRentManager)
        {
            _timetableRentManager = timetableRentManager;
        }
        public async Task<IActionResult> TimetableRentPage()
        {
            var cg = await _timetableRentManager.GetAll();
            return View(cg);
        }

        public IActionResult CreateTimetableRent()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTimetableRent(TimetableRent timetableRent)
        {
            await _timetableRentManager.AddTimetableRent(timetableRent.Time, timetableRent.Data);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTimetableRent()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteTimetableRent(TimetableRent timetableRent)
        {
            await _timetableRentManager.DeleteTimetableRent(timetableRent.ID);
            return RedirectToAction("Index");
        }


        [HttpGet]
        [Route("timetableRents")]
        public Task<IList<TimetableRent>> GetAll() => _timetableRentManager.GetAll();

        [HttpPut]
        [Route("timetableRents")]
        public Task AddTimetableRent([FromBody] TimetableRent timetableRent) => _timetableRentManager.AddTimetableRent(timetableRent.Time, timetableRent.Data);

        [HttpDelete]
        [Route("timetableRents/{id}")]
        public Task DeleteTimetableRent(int id) => _timetableRentManager.DeleteTimetableRent(id);
    }
}
