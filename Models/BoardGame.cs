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
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int MaxPlayers { get; set; }
        [Required]
        public int Playtime { get; set; }
        [Required]
        public string Photo { get; set; }
        [Required]
        public string Room { get; set; }

        [ForeignKey(nameof(Room))]
        public virtual Rooms Rooms { get; set; }

        public BoardGame(string Name, int MaxPlayers, int Playtime, string Photo, string RoomID)
        {
            this.Name = Name;
            this.MaxPlayers = MaxPlayers;
            this.Playtime = Playtime;
            this.Photo = Photo;
            this.Room = RoomID;
        }
    }
}
