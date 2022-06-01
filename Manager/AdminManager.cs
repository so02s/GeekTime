using System;
using GeekTime.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeekTime.Manager
{
    public interface IAdminManager
    {
        Task<IList<Admin>> GetAll();
        Task AddAdmin(string Name, string Events, byte[] Image);
        Task DeleteAdmin(int id);
    }

    public class AdminManager : IAdminManager
    {
        private readonly GeekTime.Site_Data.GeekTimeContext _context;

        public AdminManager(GeekTime.Site_Data.GeekTimeContext context)
        {
            _context = context;
        }
        public async Task AddAdmin(string _name, string _events, byte[] _image)
        {
            var admin = new Admin(_name, _events, _image);
            _context.Admins.Add(admin);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAdmin(int id)
        {
            var admin = _context.Admins.Find(id);
            if(admin != null)
            {
                _context.Admins.Remove(admin);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IList<Admin>> GetAll() => await _context.Admins.ToListAsync();
    }
}