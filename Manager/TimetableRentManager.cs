using System;
using GeekTime.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeekTime.Manager
{
    public interface ITimetableRentManager
    {
        Task<IList<TimetableRent>> GetAll();
        Task AddTimetableRent(int Time, string Data, int RateID);
        Task DeleteTimetableRent(int id);
    }
    public class TimetableRentManager : ITimetableRentManager
    {
        private readonly GeekTime.Site_Data.GeekTimeContext _context;

        public TimetableRentManager(GeekTime.Site_Data.GeekTimeContext context)
        {
            _context = context;
        }
        public async Task AddTimetableRent(int Time, string Data, int RateID)
        {
            var timetableRent = new TimetableRent(Time,  Data, RateID);
            _context.TimetableRents.Add(timetableRent);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTimetableRent(int id)
        {
            var timetableRent = _context.TimetableRents.Find(id);
            if (timetableRent != null)
            {
                _context.TimetableRents.Remove(timetableRent);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IList<TimetableRent>> GetAll() => await _context.TimetableRents.ToListAsync();
    }
}
