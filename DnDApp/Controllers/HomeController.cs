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
            ViewData["MonsterNames"] = ReturnMonsterNames();
            ViewData["MonsterUrls"] = ReturnMonsterUrls();
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

        public List<Monster> ListOfMonsters()
        {
            List<Monster> MonsterList = new List<Monster>();
            var Monsters = GetMonsters();
            Monster AllTheMonsters = new Monster();

            for (int i = 0; i < Monsters.Count(); i++)
            {
                foreach (var M in Monsters)
                {
                    AllTheMonsters.Name = M["results"][i]["name"].ToString();
                    AllTheMonsters.Url = M["results"][i]["url"].ToString();
                    MonsterList.Add(AllTheMonsters);
                }
            }
            
            return MonsterList;
        }
        public List<string> ReturnMonsterNames()
        {
            List<String> MonsterNames = new List<string>();
            var Monsters = ListOfMonsters();
            
            foreach (Monster M in Monsters)
            {
                MonsterNames.Add(M.Name);
            }
            return MonsterNames;
        }
        public List<string> ReturnMonsterUrls()
        {
            List<String> MonsterUrls = new List<string>();
            var Monsters = ListOfMonsters();
            
            foreach (Monster M in Monsters)
            {
                MonsterUrls.Add(M.Url);
            }
            return MonsterUrls;
        }
    }
}
