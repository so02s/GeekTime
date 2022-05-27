using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace GeekTime.Models
{
    public class Contacts
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long TelNumber { get; set; }
        public string Mail { get; set; }
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
