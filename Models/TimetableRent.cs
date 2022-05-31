using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekTime.Models
{
    public class TimetableRent
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int Time { get; set; } //время
        [Required]
        public string Data { get; set; } //дата
        [Required]
        public int RateID { get; set; } //цены

        [ForeignKey(nameof(RateID))]
        public virtual Rates Rates { get; set; }

        public TimetableRent(int Time, string Data, int Rate)
        {
            this.Time = Time;
            this.Data = Data;
            this.RateID = Rate;
        }
    }
}
