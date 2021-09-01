using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder.Classes
{
    public class SearchResults
    {
        public List<SearchResult> Search { get; set; }
        public string totalResults { get; set; }
        public bool Response { get; set; }
    }

    public class SearchResult
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }
    }

    public class GameSearchResults
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<GameSearchResult> results { get; set; }
    }

    public class GameSearchResult
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public string playtime { get; set; }
        public List<Platforms> platforms { get; set; }
    }

    public class Platforms
    {
        public Platform platform { get; set; }
    }

    public class Platform
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }
}
