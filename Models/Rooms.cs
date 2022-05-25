using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Models
{
    public class Rooms
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Events { get; set; }
        public string Rates { get; set; }
        public string Timetable { get; set; }
        public Rooms(string Name, string Image, string Events, string Rates, string Timetable)
        {
            this.Name = Name;
            this.Image = Image;
            this.Events = Events;
            this.Rates = Rates;
            this.Timetable = Timetable;
        }
    }
}
