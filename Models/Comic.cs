using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekTime.Models
{
    public class Comic
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public int RoomID { get; set; }

        [ForeignKey(nameof(RoomID))]
        public virtual Room Rooms { get; set; }

        public Comic()
        {

        }
        public Comic(string Name, string Genre, int Room)
        {
            this.Name = Name;
            this.Genre = Genre;
            this.RoomID = Room;
        }
    }
}
