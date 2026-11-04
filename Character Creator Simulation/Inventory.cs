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
        public WeaponAdapter(Weapon weapon) : base(weapon.Name, $"A {weapon.Type} that deals {weapon.Damage} damage.")
        {
            _weapon = weapon;
        }
    }

    public class PotionAdapter : Item
    {
        private readonly Potion _potion;
        public string Name;
        public string Desc;
        public PotionAdapter (Potion potion) : base (potion.Name, $"Applies {potion.Effect} to whoever drinks it.")
        {
            _potion = potion;
        }
    }

    public class Inventory
    {
        public Dictionary<String, Item> Contents = new();
        public bool AddItem(Item item)
        {
            return Contents.TryAdd(item.Name, item);
        }
        public bool AddItem(Weapon weapon)
        {
            Item item = new WeaponAdapter(weapon);
            return Contents.TryAdd(item.Name, item);
        }
        public bool AddItem(Potion potion)
        {
            Item item = new PotionAdapter(potion);
            return Contents.TryAdd(item.Name, item);
        }
        public Item GetItem(String name)
        {
            return Contents[name];
        }
        public void PrintItems()
        {
            foreach(KeyValuePair<String, Item> kvp in Contents)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Desc}");
            }
        }
        public bool RemoveItem(String name)
        {
            return Contents.Remove(name);
        }
    }
}
