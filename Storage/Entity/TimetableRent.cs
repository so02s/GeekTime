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
    public class TimetableRent
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
