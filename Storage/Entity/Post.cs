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
    public class Post
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Vk_link { get; set; }
        public string Image { get; set; }
        public string Describtion { get; set; }
        public string Admin { get; set; }
        public Post(string Vk_link, string Image, string Describtion, string Admin)
        {
            this.Vk_link = Vk_link;
            this.Image = Image;
            this.Describtion = Describtion;
            this.Admin = Admin;
        }
    }
}
