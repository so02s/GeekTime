using System;
using GeekTime.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Manager
{
    public interface IConsoleGameManager
    {
        IEnumerable<ConsoleGames> consolegame { get; }
        IEnumerable<ConsoleGames> GetConsoleGameByName(string name);
        void AddConsoleGame(ConsoleGames consolegame);
    }
    public class ConsoleGamesManager : IConsoleGameManager
    {
            public IEnumerable<ConsoleGames> consolegame => ConsoleGameList.consoleGames;

            public void AddConsoleGame(ConsoleGames consoleGame)
            {
            ConsoleGameList.consoleGames.Add(consoleGame);
            }

            public IEnumerable<ConsoleGames> GetConsoleGameByName(string name)
            {
                return ConsoleGameList.consoleGames.Where(cg => cg.Name.ToLower() == name.ToLower());
            }
        public static class ConsoleGameList
        {
            public static List<ConsoleGames> consoleGames = new List<ConsoleGames>()
            {
                /*
                 new ConsoleGames("Overcooked!", 6, "Xbox One", "Шелдон"),
                 new ConsoleGames("Mortal Combat 11", 2, "PS4 PRO", "Время приключений"),
                 new ConsoleGames("Moving Out", 6, "Xbox One", "Татуин"),
                 new ConsoleGames("It takes two", 2, "Xbox SeriaS", "Тардис"),
                */
            };
        }
    }
}
