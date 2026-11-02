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

        public Item(string name, string desc)
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

    public class WeaponAdapter : Item
    {
        private readonly Weapon _weapon;
        public string Name;
        public string Desc;
        public WeaponAdapter(Weapon weapon) : base(weapon.Name, weapon.Type)
        {
            _weapon = weapon;
            Name = weapon.Name;
            Desc = $"A {weapon.Type} that deals {weapon.Damage} damage.";
        }
    }

    public class PotionAdapter : Item
    {
        private readonly Potion _potion;
        public string Name;
        public string Desc;
        public PotionAdapter (Potion potion) : base (potion.Name, potion.Effect)
        {
            _potion = potion;
            Name = potion.Name;
            Desc = $"Applies {potion.Effect} to whoever drinks it.";
        }
    }
}
