using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekTime.Models
{
    public class Rates
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Cost { get; set; }
        public Rates(string Name, int Cost)
        {
            this.Name = Name;
            this.Cost = Cost;
        }
    }
}
