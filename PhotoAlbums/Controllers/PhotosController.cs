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
    public class PhotosController : Controller
    {
        private const string PHOTOS_API_URL = "http://jsonplaceholder.typicode.com/photos";

        // GET: AlbumsController
        public async Task<ActionResult> List()
        {
            List<Photo> photoList = new List<Photo>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(PHOTOS_API_URL))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    photoList = JsonConvert.DeserializeObject<List<Photo>>(apiResponse);
                }
            }
            return View(photoList);
        }


        public async Task<ActionResult> PhotosByAlbum(int id)
        {
            List<Photo> photoList = new List<Photo>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(PHOTOS_API_URL))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    photoList = JsonConvert.DeserializeObject<List<Photo>>(apiResponse);
                    photoList =  photoList.Where(x => x.albumId == id).ToList();
                }
            }
            return View("List", photoList);
        }

        // GET: AlbumsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
