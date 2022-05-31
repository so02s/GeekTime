using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeekTime.Models
{
    public class Contacts
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        public Contacts(string Name, long TelNumber, string Mail, string Post)
        {
            this.Name = Name;
            this.TelNumber = TelNumber;
            this.Mail = Mail;
            this.Post = Post;
        }
    }
} 
