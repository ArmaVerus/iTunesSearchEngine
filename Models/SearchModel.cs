using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Web.Mvc;

namespace iTunesSearchEngine.Models
{
    public class ItemResult
    {
        public string trackName { get; set; }
        public DateTime releaseDate { get; set; }
        public string artworkUrl100 { get; set; }
    }
    public class SearchBar 
    {
        public string SearchQuery { get; set; }
        public Category SearchCategory { get; set; }
        public List<ItemResult> Results { get; set; }

    }
    public enum Category 
    {
        movie,
        podcast,
        music,
        musicVideo,
        audioBook,
        shortFilm,
        tvShow,
        software,
        ebook

    }
}