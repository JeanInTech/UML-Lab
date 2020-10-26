using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RPG_UML
{
    class GameCharacter
    {
        private string name;
        private int strength;
        private int intelligence;
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public GameCharacter() { }
        public GameCharacter(string Name, int Strength, int Intelligence)
        {
            this.Name = Name;
            this.Strength = Strength;
            this.Intelligence = Intelligence;
        }
        public virtual void Play()
        {
            Console.WriteLine($"Character Name: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
        }
        public GameCharacter CreateCharacter()
        {
            Console.WriteLine("What the name of your new character?");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("What's your character's strength?");
            int strength = Int32.Parse(Console.ReadLine().Trim());
            Console.WriteLine("What's your character's intelligence?");
            int intelligence = Int32.Parse(Console.ReadLine().Trim());

            return new GameCharacter(name, strength, intelligence);
        }
    }
}
