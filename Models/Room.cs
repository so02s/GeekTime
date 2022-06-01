using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekTime.Models
{
    public class Room
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Image { get; set; }
        public int EventId { get; set; }

        [ForeignKey(nameof(EventId))]
        public virtual Event Events { get; set; }
        public int RateID { get; set; }

        [ForeignKey(nameof(RateID))]
        public virtual Rate Rates { get; set; }
        public int TimetableRentID { get; set; }

        [ForeignKey(nameof(TimetableRentID))]
        public virtual TimetableRent TimetableRent { get; set; }

        public Room()
        {

        }
        public Room(string Name, string Image, int Events, int Rates, int Timetable)
        {
            this.Name = Name;
            this.Image = Image;
            this.EventId = Events;
            this.RateID = Rates;
            this.TimetableRentID = Timetable;
        }
    }
}
