using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDApp.Models
{
    public class Spell
    {
        int ID { get; set; }
        int Index { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string HigherLevelDescription { get; set; }
        string Page { get; set; }
        string Range { get; set; }
        Component Components { get; set; }
        string Material { get; set; }
        bool Ritual { get; set; }
        string Duration { get; set; }
        bool Consentration { get; set; }
        string CastingTime { get; set; }
        int Level { get; set; }
        MagicSchool MagicSchool { get; set; }
        CharacterClass AllowedClass { get; set; }
        SubClass AllowedSubClass { get; set; }
    }
}
