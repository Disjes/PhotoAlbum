using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PhotoAlbums.Models;

namespace PhotoAlbums.Controllers
{
    public class CommentsController : Controller
    { 
        private const string COMMENTS_API_URL = "http://jsonplaceholder.typicode.com/comments";

        // GET: AlbumsController
        public async Task<ActionResult> List()
        {
            List<Comment> commentList = new List<Comment>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(COMMENTS_API_URL))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    commentList = JsonConvert.DeserializeObject<List<Comment>>(apiResponse);
                }
            }
            return View(commentList);
        }


        public async Task<ActionResult> CommentsByPhoto(int id)
        {
            List<Comment> commentList = new List<Comment>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(COMMENTS_API_URL))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    commentList = JsonConvert.DeserializeObject<List<Comment>>(apiResponse);
                    commentList = commentList.Where(x => x.postId == id).ToList();
                }
            }
            return PartialView("List", commentList);
        }
    }
}
