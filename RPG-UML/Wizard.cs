using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_UML
{
    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }
        public Wizard() { }
        public Wizard(string Name, int Strength, int Intelligence, int MagicalEnergy, int SpellNumber):base(Name, Strength, Intelligence, MagicalEnergy)
        {
            this.SpellNumber = SpellNumber;
        }
        public override void Play()
        {
            Console.WriteLine($"Magic User Type: Wizard");
            base.Play();
            Console.WriteLine($"Number of Spells: {SpellNumber}");
        }
    }
}
