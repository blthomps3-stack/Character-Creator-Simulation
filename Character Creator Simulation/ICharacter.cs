using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator_Simulation
{
    public interface ICharacter
    {
        int Health { get; set; }
        int Defense { get; set; }
        int Speed { get; set; }
        int Strength { get; set; }
        int Intellect { get; set; }
        int Agility { get; set; }

        void Act();
        void Speak();
        void PrintDetails();
    }

    public class Human : ICharacter
    {
        public int Health { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Speed { get; set; } = 10;
        public int Strength { get; set; } = 10;
        public int Intellect { get; set; } = 10;
        public int Agility { get; set; } = 10;
        public void Act()
        {

        }
        public void Speak()
        {

        }

        public void PrintDetails()
        {

        }
    }

    public class Elf : ICharacter
    {
        public int Health { get; set; } = 8;
        public int Defense { get; set; } = 8;
        public int Speed { get; set; } = 12;
        public int Strength { get; set; } = 8;
        public int Intellect { get; set; } = 12;
        public int Agility { get; set; } = 12;
        public void Act()
        {

        }
        public void Speak()
        {

        }

        public void PrintDetails()
        {

        }
    }

    public class Dwarf : ICharacter
    {
        public int Health { get; set; } = 12;
        public int Defense { get; set; } = 12;
        public int Speed { get; set; } = 8;
        public int Strength { get; set; } = 12;
        public int Intellect { get; set; } = 8;
        public int Agility { get; set; } = 8;
        public void Act()
        {

        }
        public void Speak()
        {

        }

        public void PrintDetails()
        {

        }
    }
}
