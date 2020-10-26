using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RPG_UML
{
    class GameCharacter
    {
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
    }
}
