using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Models
{
    public class Comics
    {
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
