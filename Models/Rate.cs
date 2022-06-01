using System.ComponentModel.DataAnnotations;

namespace GeekTime.Models
{
    public class Rate
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Cost { get; set; }

        public Rate()
        {

        }
        public Rate(string Name, int Cost)
        {
            this.Name = Name;
            this.Cost = Cost;
        }
    }
}
