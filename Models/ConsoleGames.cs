using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Models
{
    public class ConsoleGames
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxPlayers { get; set; }
        public string WhatConsole { get; set; }
        public string Rooms { get; set; }
        public ConsoleGames(string Name, int MaxPlayers, string WhatConsole, string Rooms)
        {
            this.Name = Name;
            this.MaxPlayers = MaxPlayers;
            this.WhatConsole = WhatConsole;
            this.Rooms = Rooms;
        }
    }
}
