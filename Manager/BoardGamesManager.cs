using System;
using GeekTime.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Manager
{
    public interface IBoardGameManager
    {
        IEnumerable<BoardGame> boardgame { get; }
        IEnumerable<BoardGame> GetBoardGameByName(string name);
        void AddBoardGame(BoardGame boardgame);
    }
    public class BoardGamesManager : IBoardGameManager
    {
        public IEnumerable<BoardGame> boardgame => BoardGameList.boardgame;

        public void AddBoardGame(BoardGame boardgame)
        {
            BoardGameList.boardgame.Add(boardgame);
        }

        public IEnumerable<BoardGame> GetBoardGameByName(string name)
        {
            return BoardGameList.boardgame.Where(bg => bg.Name.ToLower() == name.ToLower());
        }
        public static class BoardGameList
        {
            public static List<BoardGame> boardgame = new List<BoardGame>()
            {
             new BoardGame("Terranova", 8, 120, "адрес фотки"),
             new BoardGame("Caverna", 4, 120, "адрес фотки"),
             new BoardGame("Taverna of Dragon", 6, 60, "адрес фотки"),
             new BoardGame("Onitama", 2, 20, "адрес фотки"),
            };
        }
    }
}
