using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
*/

namespace GeekTime.Storage.Entity
{
    public class ConsoleGames
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
