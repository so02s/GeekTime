using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekTime.Models
{
    public class Comics
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public int RoomID { get; set; }

        [ForeignKey(nameof(RoomID))]
        public virtual Rooms Rooms { get; set; }

        public Comics(string Name, string Genre, int RoomID)
        {
            this.Name = Name;
            this.Genre = Genre;
            this.RoomID = RoomID;
        }
    }
}
