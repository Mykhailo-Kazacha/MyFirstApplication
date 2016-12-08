using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapons;
using MyFirstApplication;

namespace Characters
{
    public class Character : Creature
    {
        
        public delegate void CreatureDeath(string message);
        //событие, вызываемое когда персонаж убивает
        public event CreatureDeath Kill;

        protected virtual void OnKill(string message)
        {
            if (Kill!=null)
            {
                Kill(message);
            }
        }

        //событие, вызываемое когда персонажа убивают
        public event CreatureDeath Death;
        public virtual void OnDeath(string message)
        {
            if (Death != null)
            {
                Death(message);
            }
        }

        //оружие. По умолчанию - без оружия
        private IWeapon _weapon=new Unarmed();

        public IWeapon Weapon
        {
            get
            {
                return _weapon;
            }
            set
            {
                _weapon = value;
            }
        }

        public Races Race { get; set; }
        public string Name { get; set; }

        //стандартный персонаж
        public Character()
        {
            SetStats(Races.human);
            Name = "Noname";
        }

        public Character(Races race) : base()
        {
            SetStats(race);
        }

        //статы персонажа в зависимости от рассы (Человек, Эльф, Орк)
        private void SetStats(Races race)
        {
            Race = race;
            switch (race)
            {
                case Races.human:

                    Strength = 10;
                    Agility = 10;
                    MaxHealth = 50;
                    CurrentHealth = 50;
                    Mana = 25;
                    break;
                case Races.elf:
                    Strength = 5;
                    Agility = 15;
                    MaxHealth = 30;
                    CurrentHealth = 30;
                    Mana = 50;
                    break;
                case Races.orc:
                    Race = Races.orc;
                    Strength = 15;
                    Agility = 10;
                    MaxHealth = 75;
                    CurrentHealth = 75;
                    Mana = 0;
                    break;
                default:
                    Strength = 10;
                    Agility = 10;
                    MaxHealth = 50;
                    CurrentHealth = 50;
                    Mana = 25;
                    break;
            }
        }

        //вывод статов куда-нибудь
        public override void DisplayStats()
        {
 //           Console.WriteLine("{0}'s strength is {1}", Name, Strength);
 //           Console.WriteLine("{0}'s agility is {1}", Name, Agility);
//            Console.WriteLine("{0}'s lifetotal is {1}", Name, MaxHealth);
 //           Console.WriteLine("{0} has {1} life", Name, CurrentHealth);
//            Console.WriteLine("{0}'s mana is {1}", Name, Mana);
//            Console.WriteLine("{0} is {1}", Name, Race);
 //           Console.WriteLine("{0}'s coordinates are ({1}, {2}, {3})", Name, PositionX, PositionY, PositionZ);
        }
    }
}
