using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekTime.Models
{
    public class TimetableRent
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Time { get; set; } //время
        [Required]
        public string Data { get; set; } //дата
        public int RateID { get; set; } //цены

        public TimetableRent()
        {

        }
        public TimetableRent(int Time, string Data)
        {
            this.Time = Time;
            this.Data = Data;
        }
    }
}
