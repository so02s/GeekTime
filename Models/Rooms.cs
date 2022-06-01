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
        public string Event { get; set; }

        [ForeignKey(nameof(Event))]
        public virtual Event Events { get; set; }

        [Required]
        public string Rate { get; set; }

        [ForeignKey(nameof(Rate))]
        public virtual Rates Rates { get; set; }

        [Required]
        public string TimetableRents { get; set; }

        [ForeignKey(nameof(TimetableRents))]
        public virtual TimetableRent TimetableRent { get; set; }

        public Rooms(string Name, string Image, string Events, string Rates, string Timetable)
        {
            this.Name = Name;
            this.Image = Image;
            this.Event = Events;
            this.Rate = Rates;
            this.TimetableRents = Timetable;
        }
    }
}
