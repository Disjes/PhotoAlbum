using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PhotoAlbums.Models;

namespace PhotoAlbums.Controllers
{
    public class AlbumsController : Controller
    {

        private const string ALBUMS_API_URL = "http://jsonplaceholder.typicode.com/albums";

        // GET: AlbumsController
        public async Task<ActionResult> List()
        {
            List<Album> albumList = new List<Album>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ALBUMS_API_URL))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    albumList = JsonConvert.DeserializeObject<List<Album>>(apiResponse);
                }
            }
            return View(albumList);
        }

        // GET: AlbumsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
