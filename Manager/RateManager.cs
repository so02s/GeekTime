using System;
using GeekTime.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeekTime.Manager
{
    public interface IRateManager
    {
        Task<IList<Rate>> GetAll();
        Task AddRate(string Name, int Cost);
        Task DeleteRate(int id);
    }
    public class RateManager : IRateManager
    {
        private readonly GeekTime.Site_Data.GeekTimeContext _context;

        public RateManager(GeekTime.Site_Data.GeekTimeContext context)
        {
            _context = context;
        }
        public async Task AddRate(string Name, int Cost)
        {
            var rate = new Rate(Name, Cost);
            _context.Rates.Add(rate);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRate(int id)
        {
            var rate = _context.Rates.Find(id);
            if (rate != null)
            {
                _context.Rates.Remove(rate);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IList<Rate>> GetAll() => await _context.Rates.ToListAsync();
    }
}
