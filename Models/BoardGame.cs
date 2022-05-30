using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekTime.Models
{
    public class BoardGame
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxPlayers { get; set; }
        public int Playtime { get; set; }
        public string Rooms { get; set; } 
        public BoardGame(string Name, int MaxPlayers, int Playtime, string Rooms)
        {
            this.Name = Name;
            this.MaxPlayers = MaxPlayers;
            this.Playtime = Playtime;
            this.Rooms = Rooms;
        }
    }
}
