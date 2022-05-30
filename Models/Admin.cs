using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekTime.Models
{
    public class Admin
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Events { get; set; }
        [Required]
        public string Image { get; set; }
        public override string ToString()
        {
            return $"Админ: {Name}, он ведет: {Events}, Вот как он выглядит: {Image}";
        }
 public Admin(string Name, string Events, string Image)
        {
            this.Name = Name;
            this.Events = Events;
            this.Image = Image;
        }
    }
}