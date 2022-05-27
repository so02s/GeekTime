using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Models
{
    public class TimetableRent
    {
        public int ID { get; set; }
        public int Time { get; set; } //время
        public string Data { get; set; } //дата
        public int Rate { get; set; } //цены
        public TimetableRent(int Time, string Data, int Rate)
        {
            this.Time = Time;
            this.Data = Data;
            this.Rate = Rate;
        }
    }
}
