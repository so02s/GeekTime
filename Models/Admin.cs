using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;

namespace GeekTime.Models
{
    public class Admin
    {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Events { get; set; }
            public string Image { get; set; }
            public override string ToString() => $"Админ: {Name}, он ведет: {Events}, Вот как он выглядит: {Image}";
 public Admin(string Name, string Events, string Image)
        {
            this.Name = Name;
            this.Events = Events;
            this.Image = Image;
        }
    }
}