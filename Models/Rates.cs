using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Models
{
    public class Rates
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public Rates(string Name, int Cost)
        {
            this.Name = Name;
            this.Cost = Cost;
        }
    }
}
