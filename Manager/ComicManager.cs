using GeekTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeekTime.Manager
{
    public interface IComicManager
    {
        Task<IList<Comic>> GetAll();
        Task AddComic(string Name, string Genre, int RoomID);
        Task DeleteComic(int id);
    }

    public class ComicManager : IComicManager
    {
        private readonly GeekTime.Site_Data.GeekTimeContext _context;

        public ComicManager(GeekTime.Site_Data.GeekTimeContext context)
        {
            _context = context;
        }
        public async Task AddComic(string _name, string _genre, int _roomid)
        {
            var comic = new Comic(_name, _genre, _roomid);
            _context.Comics.Add(comic);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteComic(int id)
        {
            var comic = _context.Comics.Find(id);
            if (comic != null)
            {
                _context.Comics.Remove(comic);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IList<Comic>> GetAll() => await _context.Comics.ToListAsync();
    }
}
