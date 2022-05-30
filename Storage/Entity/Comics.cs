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
    public class Comics
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Room { get; set; }

        public Comics(string Name, string Genre, string Room)
        {
            this.Name = Name;
            this.Genre = Genre;
            this.Room = Room;
        }
    }
}
