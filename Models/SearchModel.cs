using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Web.Mvc;

namespace iTunesSearchEngine.Models
{
    //public class ViewModel 
    //{
    //    public IEnumerable<PopulatedSearch> ResultSearch { get; set; }
    //    public IEnumerable<SearchBar> SearchBar { get; set; }
    //}
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

    //public class EnumDisplayNameAttribute : Attribute
    //{
    //    private string _displayName;
    //    public string DisplayName
    //    {
    //        get { return _displayName; }
    //        set { _displayName = value; }
    //    }
    //}
    public enum Category 
    {
        movie,
        podcast,
        music,
        //[EnumDisplayName(DisplayName = "Music Video")]
        musicVideo,
        //[EnumDisplayName(DisplayName = "Audio Book")]
        audioBook,
        //[EnumDisplayName(DisplayName = "Short Film")]
        shortFilm,
        //[EnumDisplayName(DisplayName = "TV Show")]
        tvShow,
        software,
        //[EnumDisplayName(DisplayName = "E-Book")]
        ebook

    }
}