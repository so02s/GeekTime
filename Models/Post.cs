using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Models
{
    public class Post
    {
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
