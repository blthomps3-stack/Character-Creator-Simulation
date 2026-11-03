using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator_Simulation
{
    public interface ICharacter
    {
        string Name { get; set; }
        int Health { get; set; }
        int Defense { get; set; }
        int Speed { get; set; }
        int Strength { get; set; }
        int Intellect { get; set; }
        int Agility { get; set; }
        Inventory Inv { get; set; }

        void Act();
        void Speak();
        void PrintDetails()
        {
            Console.WriteLine(Name);

            Console.WriteLine($"Health: {this.Health}");
            Console.WriteLine($"Defense: {this.Defense}");
            Console.WriteLine($"Speed: {this.Speed}");
            Console.WriteLine($"Strength: {this.Strength}");
            Console.WriteLine($"Intellect: {this.Intellect}");
            Console.WriteLine($"Agility: {this.Agility}");
        }
    }

    public class Human : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Speed { get; set; } = 10;
        public int Strength { get; set; } = 10;
        public int Intellect { get; set; } = 10;
        public int Agility { get; set; } = 10;
        public Inventory Inv { get; set; } = new Inventory();

        public Human(string name)
        {
            Name = name;
        }
        public virtual void Act()
        {

        }
        public virtual void Speak()
        {

        }
    }

    public class Elf : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; } = 8;
        public int Defense { get; set; } = 8;
        public int Speed { get; set; } = 12;
        public int Strength { get; set; } = 8;
        public int Intellect { get; set; } = 12;
        public int Agility { get; set; } = 12;
        public Inventory Inv { get; set; } = new Inventory();
        public Elf (string name)
        {
            Name = name;
        }
        public virtual void Act()
        {

        }
        public virtual void Speak()
        {

        }
    }

    public class Dwarf : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; } = 12;
        public int Defense { get; set; } = 12;
        public int Speed { get; set; } = 8;
        public int Strength { get; set; } = 12;
        public int Intellect { get; set; } = 8;
        public int Agility { get; set; } = 8;
        public Inventory Inv { get; set; } = new Inventory();
        public Dwarf(string name)
        {
            Name = name;
        }
        public virtual void Act()
        {

        }
        public virtual void Speak()
        {

        }
    }
}
