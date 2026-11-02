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

    public class WizardDecorator : CharacterDecorator
    {
        public WizardDecorator(ICharacter character) : base(character) { character.Name += " Wizard"; character.Speed += 1; character.Intellect += 2; character.Defense -= 1; }
        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Class: Wizard");
        }

        public override void Act()
        {
            Console.WriteLine($"{_character.Name} casts a spell!");
        }

        public override void Speak()
        {
            Console.WriteLine($"{_character.Name} says magic words.");
        }
    }

    public class FighterDecorator : CharacterDecorator
    {
        public FighterDecorator(ICharacter character) : base(character) { character.Name += " Fighter"; character.Agility += 1; character.Strength += 2; character.Intellect -= 1; }
        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Class: Fighter");
        }

        public override void Act()
        {
            Console.WriteLine($"{_character.Name} throws a punch!");
        }

        public override void Speak()
        {
            Console.WriteLine($"{_character.Name} says a battlecry.");
        }
    }

    public class ClericDecorator : CharacterDecorator
    {
        public ClericDecorator(ICharacter character) : base(character) { character.Name += " Cleric"; character.Defense += 1; character.Health += 2; character.Speed -= 1; }
        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Class: Cleric");
        }

        public override void Act()
        {
            Console.WriteLine($"{_character.Name} swings a mace!");
        }

        public override void Speak()
        {
            Console.WriteLine($"{_character.Name} says a prayer.");
        }
    }

    public class RogueDecorator : CharacterDecorator
    {
        public RogueDecorator(ICharacter character) : base(character) { character.Name += " Rogue"; character.Speed += 1; character.Agility += 2; character.Health -= 1; }
        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Class: Rogue");
        }

        public override void Act()
        {
            Console.WriteLine($"{_character.Name} tosses a dagger!");
        }

        public override void Speak()
        {
            Console.WriteLine($"{_character.Name} says nothing.");
        }
    }
}
