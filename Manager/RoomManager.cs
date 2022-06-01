using System;
using GeekTime.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeekTime.Manager
{
    public interface IRoomManager
    {
        Task<IList<Room>> GetAll();
        Task AddRoom(string Name, string Image, int Event, int RateID, int TimetableRentID);
        Task DeleteRoom(int id);
    }
    public class RoomManager : IRoomManager
    {
        private readonly GeekTime.Site_Data.GeekTimeContext _context;

        public RoomManager(GeekTime.Site_Data.GeekTimeContext context)
        {
            _context = context;
        }
        public async Task AddRoom(string Name, string Image, int Event, int RateID, int TimetableRentID)
        {
            var room = new Room(Name, Image, Event, RateID, TimetableRentID);
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoom(int id)
        {
            var room = _context.Rooms.Find(id);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IList<Room>> GetAll() => await _context.Rooms.ToListAsync();
    }
}
