using System.ComponentModel.DataAnnotations;

namespace GeekTime.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        [Required (ErrorMessage = "Имя должно быть заполнено")]
        public string Name { get; set; }
        public string Events { get; set; }
        [Required]
        public string Image { get; set; }
        public override string ToString()
        {
            return $"Админ: {Name}, он ведет: {Events}, Вот как он выглядит: {Image}";
        }
        public Admin()
        {
        }
        public Admin(string Name, string Events, string Image)
        {
            this.Name = Name;
            this.Events = Events;
            this.Image = Image;
        }
        public bool IsValid()
        {
            return false;
        }
    }
}