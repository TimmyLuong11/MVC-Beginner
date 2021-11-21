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
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            PokemonAPI allPokemon;

            using (var client = new HttpClient())
            {
                string jsonData = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon?offset=0&limit=1118").Result;
                allPokemon = JsonConvert.DeserializeObject<PokemonAPI>(jsonData);
            }

            return View(allPokemon.results);
        }

        public ActionResult Info(string id)
        {
            PokemonInfo info;

            using (var client = new HttpClient())
            {
                string jsonData = client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{id}").Result;
                info = JsonConvert.DeserializeObject<PokemonInfo>(jsonData);
            }

            return View(info);
        }
    }
}