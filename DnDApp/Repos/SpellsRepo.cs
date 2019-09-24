using DnDApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace DnDApp.Repos
{
    public class SpellsRepo
    {
        public async Task<Spell> GetSpellByIdAsync(int id)
        {
            var url = "http://dnd5eapi.co/api/spells";

            HttpClient client = new HttpClient();

            Spell spell = null;
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                spell = await response.Content.ReadAsAsync<Spell>();
            }
            Console.WriteLine(spell);

            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //try
            //{
            //    WebResponse response = request.GetResponse();
            //    Mycustomclassname oMycustomclassname = Newtonsoft.Json.JsonConvert.DeserializeObject<Mycustomclassname>(response);
            //    Console.WriteLine(response);

            //    using (Stream responseStream = response.GetResponseStream())
            //    {
            //        StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.UTF8);
            //    }
            //}
            //catch (WebException ex)
            //{
            //    WebResponse errorResponse = ex.Response;
            //    using (Stream responseStream = errorResponse.GetResponseStream())
            //    {
            //        StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));
            //        String errorText = reader.ReadToEnd();
            //        // log errorText
            //    }
            //    throw;
            //}
            return new Spell();
        }

    }
}
