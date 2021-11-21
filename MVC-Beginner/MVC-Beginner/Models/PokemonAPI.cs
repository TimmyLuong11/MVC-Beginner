using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Beginner.Models
{
    public class PokemonAPI
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previsou { get; set; }
        public List<Result> results { get; set; }

        public class Result
        {
            public string name { get; set; }
            public string url { get; set; }
        }
    }
}