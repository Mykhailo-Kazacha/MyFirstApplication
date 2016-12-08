using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapons;
using MyFirstApplication;

namespace Characters
{
    class Swordsman : Character, IHaveASword, IFight
    {
        public int SwingWithSword()
        {
            int damage= r.Next(Weapon.MinDamage, Weapon.MaxDamage);
            switch (Race)
            {
                case Races.human:
                    return damage+2;
                case Races.elf:
                    return damage;
                case Races.orc:
                    return damage + 1;
            }
            return damage;
        }

        public Swordsman(string name, Races race) : base(race)
        {
            Name = name;
            Weapon = new Sword();
        }

        public Swordsman() : base()
        {
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
        }

        //можно было записать как виртуальный метод в Creature и перегрузить
        public void Hit(Creature opponent)
        {
            double[] coord = { PositionX - opponent.PositionX, PositionY - opponent.PositionY, PositionZ - opponent.PositionZ };
            double distance = Distance(coord);
            if (distance > Weapon.Length)
            {
                ApproachTo(opponent);
            }
            else
            {
                opponent.CurrentHealth -= SwingWithSword();
                if (opponent.CurrentHealth<=0 && this is Character)
                {
                    OnKill("Your Swordsman has won!!!");
                }

                
            }

        }

        protected override void OnKill(string message)
        {
            base.OnKill(message);
        }

        public override void OnDeath(string message)
        {
            base.OnDeath(message);
        }
    }
}
