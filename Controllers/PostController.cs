using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekTime.Manager;
using GeekTime.Models;

namespace GeekTime.Controllers
{
    public class PostController : Controller
    {
        private IPostsManager _postManager;
        public PostController(IPostsManager postManager)
        {
            _postManager = postManager;
        }
        public ViewResult PostPage()
        {
            var posts = _postManager.Post;
            return View(posts);
        }

        [HttpPost]
        public ActionResult CreatePost(string Vk_link, string Image, string Describtion, string Admin)
        {
            try
            {
                _postManager.AddPost(new Post(Vk_link, Image, Describtion, Admin));
                return RedirectToAction(nameof(PostPage));
            }
            catch
            {
                return RedirectToAction(nameof(PostPage));
            }
        }
    }
}
