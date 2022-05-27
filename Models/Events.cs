using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Models
{
    public class Events
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Describtion { get; set; }
        public string Admin { get; set; } 
        public Events(string Name, string Image, string Describtion, string Admin)
        {
            this.Name = Name;
            this.Image = Image;
            this.Describtion = Describtion;
            this.Admin = Admin;
        }
    }
}
