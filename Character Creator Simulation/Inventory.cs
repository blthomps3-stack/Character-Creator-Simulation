using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator_Simulation
{
    public class Item
    {
        public string Name { get; set; }
        public string Desc { get; set; }

        public Item(string name, string desc, double value)
        {
            Name = name;
            Desc = desc;
        }
    }

    public class Weapon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Damage { get; set; }
        public Weapon (string name, string type, int damage)
        {
            Name = name;
            Type = type;
            Damage = damage;
        }
    }

    public class Potion
    {
        public string Name { get; set; }
        public string Effect { get; set; }

        public Potion (string name, string effect)
        {
            Name = name;
            Effect = effect;
        }
    }
}
