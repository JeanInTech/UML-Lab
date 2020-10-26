using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_UML
{
    class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior() { }
        public Warrior(string Name, int Strength, int Intelligence, string WeaponType):base(Name, Strength, Intelligence)
        {
            this.WeaponType = WeaponType;
        }
        public override void Play()
        {
            Console.WriteLine($"Character Class: Warrior");
            base.Play();
            Console.WriteLine($"Weapon: {WeaponType}");
        }
    }
}
