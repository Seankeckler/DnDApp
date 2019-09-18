using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDApp.Models
{
    public class Monster
    {

            public int ID { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
            public Monster()
            {

            }

            public Monster(string Name, string Url)
            {
                this.Name = Name;
                this.Url = Url;
            }
        }
    }


