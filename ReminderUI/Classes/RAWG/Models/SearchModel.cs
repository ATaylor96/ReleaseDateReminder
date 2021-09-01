using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderUI.Classes.RAWG.Models
{
    public class RAWGSearchModels
    {
        public string apiKey = "e7cb6ac232454c8c9b5211b61d6a1cc0";

        public class GameSearch
        {
            public int count { get; set; }
            public string next { get; set; }
            public string previous { get; set; }
            public List<GameResults> results { get; set; }
            public bool user_platforms { get; set; }
        }

        public class GameResults
        {
            public string slug { get; set; }
            public string name { get; set; }
            public int playtime { get; set; }
            public List<Platform> platforms { get; set; }
            public List<Store> stores { get; set; }
            public string released { get; set; }
            public bool tba { get; set; }
            public string background_image { get; set; }
            public float rating { get; set; }
            public int rating_top { get; set; }
            public List<Ratings> ratings { get; set; }
            public int ratings_count { get; set; }
            public string reviews_text_count { get; set; }
            public int added { get; set; }
            public AddedByStatus added_by_status { get; set; }
            public string metacritic { get; set; }
            public int suggestions_count { get; set; }
            public DateTime updated { get; set; }
            public ESRB_Rating esrb_rating { get; set; }

            public string user_game { get; set; }
            public int reviews_count { get; set; }
            public string saturated_color { get; set; }
            public string dominant_color { get; set; }
            public List<ShortScreenshot> short_screenshots { get; set; }
            public List<ParentPlatform> parent_platforms { get; set; }
            public List<Genre> genres { get; set; }
        }

        public class Platform
        {
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class Store
        {
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class Ratings
        {
            public int id { get; set; }
            public string title { get; set; }
            public int count { get; set; }
            public float percent { get; set; }
        }
        
        public class AddedByStatus
        {
            public int yet { get; set; }
            public int owned { get; set; }
            public int beaten { get; set; }
            public int toplay { get; set; }
            public int dropped { get; set; }
            public int playing { get; set; }
        }

        public class ESRB_Rating
        {
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public string name_en { get; set; }
            public string name_ru { get; set; }
        }

        public class ShortScreenshot
        {
            public int id { get; set; }
            public string image { get; set; }
        }

        public class ParentPlatform
        {
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }

        public class Genre
        {
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }
    }
}