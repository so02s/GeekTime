using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekTime.Models
{
    public class ConsoleGame
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int MaxPlayers { get; set; }
        [Required]
        public string WhatConsole { get; set; }
        public string Photo { get; set; }
        public int RoomID { get; set; }

        [ForeignKey(nameof(RoomID))]
        public virtual Room Rooms { get; set; }

        public ConsoleGame()
        {

        }
        public ConsoleGame(string Name, int MaxPlayers, string WhatConsole, string Photo, int Room)
        {
            this.Name = Name;
            this.MaxPlayers = MaxPlayers;
            this.WhatConsole = WhatConsole;
            this.Photo = Photo;
            this.RoomID = Room;
        }
    }
}
