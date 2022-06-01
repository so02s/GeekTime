using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class RateController : Controller
    {
        private IRateManager _rateManager;
        public RateController(IRateManager rateManager)
        {
            _rateManager = rateManager;
        }
        public async Task<IActionResult> RatePage()
        {
            var cg = await _rateManager.GetAll();
            return View(cg);
        }

        public IActionResult CreateRate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRate(Rate rate)
        {
            await _rateManager.AddRate(rate.Name, rate.Cost);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteRate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteRate(Rate rate)
        {
            await _rateManager.DeleteRate(rate.ID);
            return RedirectToAction("Index");
        }


        [HttpGet]
        [Route("rates")]
        public Task<IList<Rate>> GetAll() => _rateManager.GetAll();

        [HttpPut]
        [Route("rates")]
        public Task AddRate([FromBody] Rate rate) => _rateManager.AddRate(rate.Name, rate.Cost);

        [HttpDelete]
        [Route("rates/{id}")]
        public Task DeleteRates(int id) => _rateManager.DeleteRate(id);
    }
}

