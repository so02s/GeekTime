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
            private ITimetableRentManager _timetableManager;
            public TimetableRentController(ITimetableRentManager timetableManager)
            {
                _timetableManager = timetableManager;
            }
            public ViewResult TimetablePage()
            {
                var tt = _timetableManager.Timetable;
                return View(tt);
            }

            [HttpPost]
            public ActionResult CreateTimetable(int Time, string Data, int Rate)
        {
                try
                {
                    _timetableManager.AddTimetableRent(new TimetableRent(Time, Data, Rate));
                    return RedirectToAction(nameof(TimetablePage));
                }
                catch
                {
                    return RedirectToAction(nameof(TimetablePage));
                }
            }
        }
}
