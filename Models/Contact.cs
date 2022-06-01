using System.ComponentModel.DataAnnotations;
namespace GeekTime.Models
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public long TelNumber { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Post { get; set; } //должность
        public override string ToString() => $"{Post}: {Name} - {TelNumber}, {Mail}";

        public Contact()
        {

        }
        public Contact(string Name, long TelNumber, string Mail, string Post)
        {
            this.Name = Name;
            this.TelNumber = TelNumber;
            this.Mail = Mail;
            this.Post = Post;
        }
    }
} 
