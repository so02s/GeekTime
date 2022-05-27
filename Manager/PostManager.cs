using GeekTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekTime.Manager
{
    public interface IPostsManager
    {
        IEnumerable<Post> Post { get; }
        IEnumerable<Post> GetPostByAdmin(string Admin);
        void AddPost(Post post);
    }
    public class PostManager : IPostsManager
    {
        public IEnumerable<Post> Post => PostsList.postlist;

        public void AddPost(Post post)
        {
            PostsList.postlist.Add(post);
        }

        public IEnumerable<Post> GetPostByAdmin(string Admin)
        {
            return PostsList.postlist.Where(post => post.Admin.ToLower() ==
           Admin.ToLower());
        }
    }
    public static class PostsList
    {
        public static List<Post> postlist = new List<Post>()
        {
             new Post("link to VK", "link to image", "describtion", "link to admin"),
             new Post("link to VK", "link to image", "describtion", "link to admin"),
        };
    }
}
