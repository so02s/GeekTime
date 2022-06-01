using System;
using GeekTime.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeekTime.Manager
{
    public interface IConsoleGameManager
    {
        Task<IList<ConsoleGame>> GetAll();
        Task AddConsoleGame(string Name, int MaxPlayers, string WhatConsole, string Photo, int RoomId);
        Task DeleteConsoleGame(int id);
    }
    public class ConsoleGameManager : IConsoleGameManager
    {
        private readonly GeekTime.Site_Data.GeekTimeContext _context;

        public ConsoleGameManager(GeekTime.Site_Data.GeekTimeContext context)
        {
            _context = context;
        }
        public async Task AddConsoleGame(string Name, int MaxPlayers, string WhatConsole, string Photo, int RoomId)
        {
            var consoleGame = new ConsoleGame(Name, MaxPlayers, WhatConsole, Photo, RoomId);
            _context.ConsoleGames.Add(consoleGame);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteConsoleGame(int id)
        {
            var consoleGame = _context.ConsoleGames.Find(id);
            if (consoleGame != null)
            {
                _context.ConsoleGames.Remove(consoleGame);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IList<ConsoleGame>> GetAll() => await _context.ConsoleGames.ToListAsync();
    }
}
