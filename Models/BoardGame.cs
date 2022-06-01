using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekTime.Models
{
    public class BoardGame
    {
        [Key]
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
        public int RoomID { get; set; }

        [ForeignKey(nameof(RoomID))]
        public virtual Room Rooms { get; set; }

        public BoardGame()
        {
                
        }
        public BoardGame(string Name, int MaxPlayers, int Playtime, string Photo, int RoomID)
        {
            this.Name = Name;
            this.MaxPlayers = MaxPlayers;
            this.Playtime = Playtime;
            this.Photo = Photo;
            this.RoomID = RoomID;
        }
    }
}
