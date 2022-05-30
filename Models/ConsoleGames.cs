using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekTime.Models
{
    public class ConsoleGames
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int MaxPlayers { get; set; }
        [Required]
        public string WhatConsole { get; set; }
        public string Photo { get; set; }
        public string Room { get; set; }

        [ForeignKey(nameof(Room))]
        public virtual Rooms Rooms { get; set; }

        public ConsoleGames(string Name, int MaxPlayers, string WhatConsole, string Photo, string Room)
        {
            this.Name = Name;
            this.MaxPlayers = MaxPlayers;
            this.WhatConsole = WhatConsole;
            this.Photo = Photo;
            this.Room = Room;
        }
    }
}
