using System.ComponentModel.DataAnnotations;

namespace GeekTime.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Events { get; set; }
        public byte[] Image { get; set; }
        public override string ToString()
        {
            return $"Админ: {Name}, он ведет: {Events}, Вот как он выглядит: {Image}";
        }
        public Admin()
        {
        }
        public Admin(string Name, string Events, byte[] Image)
        {
            this.Name = Name;
            this.Events = Events;
            this.Image = Image;
        }
    }
}