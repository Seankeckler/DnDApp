using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DnDApp.Models;
using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace DnDApp.Controllers
{
    public class HomeController : Controller
    {

        //have the monsters have a full stat card instead of entering the passive perception and stealth and other random stuff
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Monsters()
        {

            ViewData["Message"] = "Your application description page.";
            
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<JObject> GetMonsters()
        {
            List<JObject> Monsters = new List<JObject>();
            string urlString = "http://dnd5eapi.co/api/monsters";
            HttpWebRequest request = WebRequest.CreateHttp(urlString);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string ReadLine = rd.ReadToEnd();
            JObject Monster= JObject.Parse(ReadLine);
            Monsters.Add(Monster);
            return Monsters;
        }
        public MonsterList()
        {
            
            var Monsters = GetMonsters();
            var Monsters= Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(Monster);
            foreach (Monster M in Monsters)
            {
                
            }
        }
    }
}
