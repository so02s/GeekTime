using GeekTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeekTime.Manager
{
    public interface IPostManager
    {
        Task<IList<Post>> GetAll();
        Task AddPost(string Vk_link, string Image, string Describtion, int AdminID);
        Task DeletePost(int id);
    }
    public class PostManager : IPostManager
    {
        private readonly GeekTime.Site_Data.GeekTimeContext _context;

        public PostManager(GeekTime.Site_Data.GeekTimeContext context)
        {
            _context = context;
        }
        public async Task AddPost(string Vk_link, string Image, string Describtion, int AdminID)
        {
            var post = new Post(Vk_link, Image, Describtion, AdminID);
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
        }
        public async Task DeletePost(int id)
        {
            var post = _context.Posts.Find(id);
            if (post != null)
            {
                _context.Posts.Remove(post);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<Post>> GetAll() => await _context.Posts.ToListAsync();
    }
}
