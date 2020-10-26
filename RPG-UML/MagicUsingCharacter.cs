using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_UML
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }
        public MagicUsingCharacter() { }
        public MagicUsingCharacter(string Name, int Intelligence, int Strength, int MagicalEnergy) : base(Name, Intelligence, Strength)
        {
            this.MagicalEnergy = MagicalEnergy;
        }
        public override void Play()
        {
            Console.WriteLine($"Class: Magic User");
            base.Play();
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
        }
        public new MagicUsingCharacter CreateCharacter()
        {
            Console.WriteLine("What the name of your new character?");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("What's your character's strength?");
            int strength = Int32.Parse(Console.ReadLine().Trim());
            Console.WriteLine("What's your character's intelligence?");
            int intelligence = Int32.Parse(Console.ReadLine().Trim());
            Console.WriteLine("What's your character's Magical Energy?");
            int magicalEnergy = Int32.Parse(Console.ReadLine().Trim());

            return new MagicUsingCharacter(name, strength, intelligence, magicalEnergy);
        }
    }
}
