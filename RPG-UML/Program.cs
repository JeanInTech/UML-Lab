using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace RPG_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userContinue = true;
            List<GameCharacter> characterList = new List<GameCharacter>
            {
                new Warrior("Alistair", 14, 8, "Short Sword")
            };

            
            while (userContinue)
            {
                Console.WriteLine("Here's the list of all game characters:\n");
                foreach (GameCharacter character in characterList)
                {
                    character.Play();
                    Console.WriteLine(Environment.NewLine);
                }

                NewCharacter("Do you want to create a new character? [Y/N]", characterList);
                userContinue = UserContinue("Do you want to view all characters again? [Y/N]");
            }
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().Trim();
            return input;
        }
        public static bool UserContinue(string message)
        {
            string proceed = GetUserInput(message).ToLower();

            while (proceed != "n" && proceed != "y")
            {
                proceed = GetUserInput("Invalid input. Please enter [Y] to continue or [N] to exit.").ToLower();
            }
            if (proceed == "y")
            {
                return true;
            }
            else
                return false;
        }
        public static void NewCharacter(string message, List<GameCharacter> characterList)
        {
            string input = (GetUserInput(message).ToLower());
            if(input == "y")
            {
                Console.Clear();
                input = GetUserInput("Okay, do you want to create a warrior or a wizard?");
                if (input == "warrior")
                {
                    Console.WriteLine("What the name of your new character?");
                    string name = Console.ReadLine().Trim();

                    Console.WriteLine("What's your character's strength?");
                    int strength = Int32.Parse(Console.ReadLine().Trim());

                    Console.WriteLine("What's your character's intelligence?");
                    int intelligence = Int32.Parse(Console.ReadLine().Trim());

                    Console.WriteLine("What kind of weapon do they have?");
                    string weaponType = Console.ReadLine().Trim();

                    characterList.Add(new Warrior(name, strength, intelligence, weaponType));
                    Console.Clear();
                    Console.WriteLine("Your warrior has been added!");
                }
                else if (input == "wizard")
                {
                    Console.WriteLine("What the name of your new character?");
                    string name = Console.ReadLine().Trim();

                    Console.WriteLine("What's your character's strength?");
                    int strength = Int32.Parse(Console.ReadLine().Trim());

                    Console.WriteLine("What's your character's intelligence?");
                    int intelligence = Int32.Parse(Console.ReadLine().Trim());

                    Console.WriteLine("What's your character's Magical Energy?");
                    int magicalEnergy = Int32.Parse(Console.ReadLine().Trim());

                    Console.WriteLine("How many spells does your character know?");
                    int spellNumber = Int32.Parse(Console.ReadLine().Trim());

                    characterList.Add(new Wizard(name, strength, intelligence, magicalEnergy, spellNumber));
                    Console.Clear();
                    Console.WriteLine("Your new wizard has been added!");
                }
            }
        }
    }
}
