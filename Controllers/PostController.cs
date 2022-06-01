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
        private IPostManager _postManager;
        public PostController(IPostManager postManager)
        {
            _postManager = postManager;
        }
        public async Task<IActionResult> PostPage()
        {
            var cg = await _postManager.GetAll();
            return View(cg);
        }
        
        public IActionResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreatePost(Post post)
        {
            await _postManager.AddPost(post.Vk_link, post.Image, post.Describtion, post.AdminID);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePost()
        {
            return View();
        }    
        [HttpPost]
        public async Task<IActionResult> DeletePost(Post post)
        {
            await _postManager.DeletePost(post.ID);
            return RedirectToAction("Index");
        }


        [HttpGet]
        [Route("posts")]
        public Task<IList<Post>> GetAll() => _postManager.GetAll();

        [HttpPut]
        [Route("posts")]
        public Task AddPost([FromBody] Post post) => _postManager.AddPost(post.Vk_link, post.Image, post.Describtion, post.AdminID);

        [HttpDelete]
        [Route("posts/{id}")]
        public Task DeletePost(int id) => _postManager.DeletePost(id);
    }
}
