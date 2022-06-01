using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public string Room { get; set; }

        [ForeignKey(nameof(Room))]
        public virtual Rooms Rooms { get; set; }

        public Comic(string Name, string Genre, string Room)
        {
            this.Name = Name;
            this.Genre = Genre;
            this.Room = Room;
        }
    }
}
