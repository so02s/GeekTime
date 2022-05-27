using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class RatesController : Controller
    {
        private IRatesManager _ratesManager;
        public RatesController(IRatesManager ratesManager)
        {
            _ratesManager = ratesManager;
        }
        public ViewResult RatesPage()
        {
            var rates = _ratesManager.rates;
            return View(rates);
        }
    }
}
