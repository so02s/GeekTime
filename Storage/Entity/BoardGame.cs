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
    public class BoardGame
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int MaxPlayers { get; set; }
        [Required]
        public int Playtime { get; set; }
        [Required]
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
