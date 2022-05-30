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
    public class Events
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        public string Describtion { get; set; }
        [Required]
        public int AdminID;

        [ForeignKey(nameof(AdminID))]
        public virtual Admin Admin { get; set; } 

        public Events(string Name, string Image, string Describtion, int AdminID)
        {
            this.Name = Name;
            this.Image = Image;
            this.Describtion = Describtion;
            this.AdminID = AdminID;
        }
    }
}
