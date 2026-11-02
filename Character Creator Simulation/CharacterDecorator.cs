using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator_Simulation
{
    public abstract class CharacterDecorator : ICharacter
    {
        protected ICharacter _character;
        public string Name { get { return _character.Name; } set => _character.Name = value; }
        public int Health { get { return _character.Health; } set => _character.Health = value; }
        public int Defense { get { return _character.Defense; } set => _character.Defense = value; }
        public int Speed { get { return _character.Speed; } set => _character.Speed = value; }
        public int Strength { get { return _character.Strength; } set => _character.Strength = value; }
        public int Intellect { get { return _character.Intellect; } set => _character.Intellect = value; }
        public int Agility { get { return _character.Agility; } set => _character.Agility = value; }
        public CharacterDecorator(ICharacter character) 
        {
            _character = character;
        }

        public virtual void Act() => _character.Act();
        public virtual void Speak() => _character.Speak();
        public virtual void PrintDetails() => _character.PrintDetails();    
    }

    
}
