using GeekTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GeekTime.Site_Data;

namespace GeekTime.Manager
{
    public interface IEventManager
    {
        Task<IList<Event>> GetAll();
        Task AddEvent(string _name, string _image, string _describtion, int _adminID);
        Task DeleteEvent(int id);
    }

    public class EventManager : IEventManager
    {
        private readonly GeekTimeContext _context;

        public EventManager(GeekTimeContext context)
        {
            _context = context;
        }
        public async Task AddEvent(string _name, string _image, string _describtion, int _adminID)
        {
            var _event = new Event(_name, _image, _describtion, _adminID);
            _context.Events.Add(_event);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEvent(int id)
        {
            var _event = _context.Events.Find(id);
            if (_event != null)
            {
                _context.Events.Remove(_event);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IList<Event>> GetAll() => await _context.Events.ToListAsync();
    }
}
