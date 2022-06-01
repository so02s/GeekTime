using System;
using GeekTime.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeekTime.Manager
{
    public interface IBoardGameManager
    {
        Task<IList<BoardGame>> GetAll();
        Task AddBoardGame(string Name, int MaxPlayers, int Playtime, string Photo, int RoomID);
        Task DeleteBoardGame(int id);
    }
    public class BoardGameManager : IBoardGameManager
    {
        private readonly GeekTime.Site_Data.GeekTimeContext _context;

        public BoardGameManager(GeekTime.Site_Data.GeekTimeContext context)
        {
            _context = context;
        }
        public async Task AddBoardGame(string Name, int MaxPlayers, int Playtime, string Photo, int RoomID)
        {
            var boardGame = new BoardGame(Name, MaxPlayers, Playtime, Photo, RoomID);
            _context.BoardGames.Add(boardGame);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBoardGame(int id)
        {
            var boardGame = _context.BoardGames.Find(id);
            if (boardGame != null)
            {
                _context.BoardGames.Remove(boardGame);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IList<BoardGame>> GetAll() => await _context.BoardGames.ToListAsync();
    }
}
