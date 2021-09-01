using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderUI.Classes.TMDB.Models
{
    public class TMDBSearchModels
    {
        public string apiKey = "042a1784e44890d6d8b1484299f15b2c";

        public class MovieSearch
        {
            public int page { get; set; }
            public List<MovieResults> results { get; set; }
            public int total_results { get; set; }
            public int total_pages { get; set; }
        }

        public class MovieResults
        {
            public string poster_path { get; set; }
            public bool adult { get; set; }
            public string overview { get; set; }
            public string release_date { get; set; }
            public int[] genre_ids { get; set; }
            public int id { get; set; }
            public string original_title { get; set; }
            public string original_language { get; set; }
            public string title { get; set; }
            public string backdrop_path { get; set; }
            public float popularity { get; set; }
            public int vote_count { get; set; }
            public bool video { get; set; }
            public float vote_average { get; set; }
        }

        public class TVSearch
        {
            public int page { get; set; }
            public List<TVResults> results { get; set; }
            public int total_results { get; set; }
            public int total_pages { get; set; }
        }

        public class TVResults
        {
            public string poster_path { get; set; }
            public float popularity { get; set; }
            public int id { get; set; }
            public string backdrop_path { get; set; }
            public float vote_average { get; set; }
            public string overview { get; set; }
            public string first_air_date { get; set; }
            public string[] origin_country { get; set; }
            public int[] genre_ids { get; set; }
            public string original_language { get; set; }
            public int vote_count { get; set; }
            public string name { get; set; }
            public string original_name { get; set; }
        }
    }
}
