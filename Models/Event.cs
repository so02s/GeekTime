using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekTime.Models
{
    public class Event
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        public string Describtion { get; set; }
        [Required]
        public int AdminID { get; set; }

        [ForeignKey(nameof(AdminID))]
        public virtual Admin Admin { get; set; }

        public Event()
        {

        }
        public Event(string Name, string Image, string Describtion, int Admin)
        {
            this.Name = Name;
            this.Image = Image;
            this.Describtion = Describtion;
            this.AdminID = Admin;
        }
    }
}
