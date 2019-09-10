using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDApp.Models
{
    public class MonsterList
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public MonsterList()
        {

        }

        public MonsterList(string Name)
        {
            this.Name = Name;
        }
    }
}
