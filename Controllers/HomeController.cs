using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iTunesSearchEngine.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace iTunesSearchEngine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Search(String SearchQuery, String SearchCategory, DateTime? releaseDate) 
        {
            try
            {
                SearchBar results = new SearchBar();
                String api_template = "https://itunes.apple.com/search?term=";
                String category_template = "&media=";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(api_template + SearchQuery + category_template + SearchCategory);
                request.Method = "GET";
                request.ContentType = "application/json";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                string listresult;

                using (Stream stream = response.GetResponseStream()) 
                {
                    using (StreamReader reader = new StreamReader(stream)) 
                    {
                        listresult = reader.ReadToEnd();
                    }
                }

                results = JsonConvert.DeserializeObject<SearchBar>(listresult);
                return View(results);
            }
            catch (Exception e) {
                throw e;
            }
        }
    }
}