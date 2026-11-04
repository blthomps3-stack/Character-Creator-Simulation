using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator_Simulation
{
    public class Menu
    {
        public static void Run()
        {
            bool Running = true;
            string Input;
            GameWorld GameWorld = GameWorld.GetInstance();
            Console.WriteLine("Welcome to the character creator simulation. Select options by entering the corresponding number.");
            while (Running)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("\t1. Create a new character.");
                Console.WriteLine("\t2. Start adventuring.");
                Console.WriteLine("\t3. Quit.");
                Input = Console.ReadLine();
                if(Input == "1")
                {
                    if(GameWorld.Character == null)
                    {
                        GameWorld.Character = CharacterCreation();
                        Console.WriteLine();
                        GameWorld.Character.PrintDetails();
                    } else
                    {
                        Console.WriteLine($"Are you sure? If you do, your previous character ({GameWorld.Character.Name}) will retire from adventuring permanently.");
                        Console.WriteLine("\t1. Yes");
                        Console.WriteLine("\t2. No");
                        Input = Console.ReadLine();
                        if (Input == "1")
                        {
                            GameWorld.Character = CharacterCreation();
                            Console.WriteLine();
                            GameWorld.Character.PrintDetails();
                        }
                    }
                } else if (Input == "2")
                {

                } else if (Input == "3")
                {
                    Running = false;
                } else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
        public static ICharacter CharacterCreation()
        {
            ICharacterFactory factory;
            string Species = "";
            string Name;
            string Input;

            bool Valid;
            do
            {
                Valid = true;
                Console.WriteLine("Step 1: Select a species. Options:");
                Console.WriteLine("\t1. Human");
                Console.WriteLine("\t2. Elf");
                Console.WriteLine("\t3. Dwarf");
                Input = Console.ReadLine();
                if (Input == "1")
                {
                    Species = "Human";
                } else if (Input == "2")
                {
                    Species = "Elf";
                } else if (Input == "3")
                {
                    Species = "Dwarf";
                } else
                {
                    Console.WriteLine("Invalid input.");
                    Valid = false;
                }
            } while (!Valid);
            do
            {
                Valid = true;
                Console.WriteLine("Step 2: Enter a firstname.");
                Name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Name))
                {
                    Console.WriteLine($"Is the name {Name} correct?");
                    Console.WriteLine($"(Keep in mind that it will be stored and displayed as \"{Name} the {Species}\".)");
                    Console.WriteLine("\t1. Yes");
                    Console.WriteLine("\t2. No");
                    Input = Console.ReadLine();
                    if (Input != "1")
                    {
                        Valid = false;
                    }
                } else
                {
                    Console.WriteLine("Invalid input.");
                    Valid = false;
                }
            } while (!Valid);

            if(Species == "Human")
            {
                factory = new HumanFactory();
            } else if (Species == "Elf")
            {
                factory = new ElfFactory();
            } else if (Species == "Dwarf")
            {
                factory = new DwarfFactory();
            }
            else
            {
                Console.WriteLine("Error: Species was not properly set. Restarting character creation.");
                return CharacterCreation();
            }

            ICharacter character = factory.CreateCharacter(Name);

            do
            {
                Valid = true;
                Console.WriteLine($"Step 3: Choose a class for {character.Name}:");
                Console.WriteLine("\t1. Wizard");
                Console.WriteLine("\t2. Fighter");
                Console.WriteLine("\t3. Cleric");
                Console.WriteLine("\t4. Rogue");
                Input = Console.ReadLine();
                if (Input == "1")
                {
                    character = new WizardDecorator(character);
                }
                else if (Input == "2")
                {
                    character = new FighterDecorator(character);
                }
                else if (Input == "3")
                {
                    character = new ClericDecorator(character);
                }
                else if (Input == "4")
                {
                    character = new RogueDecorator(character);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    Valid = false;
                }
            } while (!Valid);

            return character;
        }
    }
}
