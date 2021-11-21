using MVC_Beginner.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC_Beginner.Controllers
{
    public class ChuckController : Controller
    {
        // GET: Chuck
        public ActionResult Index()
        {
            RandomChuckJokeAPI joke;

            using (var client = new HttpClient())
            {
                string jsonData = client.GetStringAsync("http://api.chucknorris.io/jokes/random").Result;
                joke = JsonConvert.DeserializeObject<RandomChuckJokeAPI>(jsonData);
            }

            return View(joke);
        }
    }
}