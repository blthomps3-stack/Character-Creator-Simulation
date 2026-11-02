using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator_Simulation
{
    public interface ICharacterFactory
    {
        ICharacter CreateCharacter(string name);
    }

    public class HumanFactory : ICharacterFactory
    {
        public ICharacter CreateCharacter(string name)
        {
            return new Human(name + " the Human");
        }
    }

    public class ElfFactory : ICharacterFactory
    {
        public ICharacter CreateCharacter(string name)
        {
            return new Elf(name + " the Elf");
        }
    }

    public class DwarfFactory : ICharacterFactory
    {
        public ICharacter CreateCharacter(string name)
        {
            return new Dwarf(name + " the Dwarf");
        }
    }
}
