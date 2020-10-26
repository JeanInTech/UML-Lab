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
    }
}
