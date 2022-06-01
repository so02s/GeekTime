using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekTime.Models
{
    public class Post
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Vk_link { get; set; }
        [Required]
        public string Image { get; set; }
        public string Describtion { get; set; }
        public int AdminID { get; set; }

        [ForeignKey(nameof(AdminID))]
        public virtual Admin Admin { get; set; }

        public Post()
        {

        }
        public Post(string Vk_link, string Image, string Describtion, int Admin)
            {
                this.Vk_link = Vk_link;
                this.Image = Image;
                this.Describtion = Describtion;
                this.AdminID = Admin;
            }
    }
}
