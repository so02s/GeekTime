using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekTime.Models
{
    public class Rooms
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required]
        public int EventID { get; set; }

        [ForeignKey(nameof(EventID))]
        public virtual Events Events { get; set; }

        [Required]
        public int RateID { get; set; }

        [ForeignKey(nameof(RateID))]
        public virtual Rates Rates { get; set; }

        [Required]
        public int TimetableRentID { get; set; }

        [ForeignKey(nameof(TimetableRentID))]
        public virtual TimetableRent TimetableRent { get; set; }

        public Rooms(string Name, string Image, int Events, int Rates, int Timetable)
        {
            this.Name = Name;
            this.Image = Image;
            this.EventID = Events;
            this.RateID = Rates;
            this.TimetableRentID = Timetable;
        }
    }
}
