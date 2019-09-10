using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDApp.Models
{


    public class Monsters
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
        public string Alignment { get; set; }
        public int AC { get; set; }
        public int HP { get; set; }
        public string HitDie { get; set; }
        public string Speed { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }

        public Monsters()
        {

        }
        
        public Monsters(string Menu, string Size, string Type, string Subtype, string Alignment, string AC, string HP, String HitDie,
          string Speed, string Str, string Dex, string Con, string Int, string Wis, string Cha)
        {

        }
    }
    



}
