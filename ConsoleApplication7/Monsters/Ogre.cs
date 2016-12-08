using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapons;
using MyFirstApplication;

namespace Monsters
{
    class Ogre : Monster, IHaveASword, IFight
    {
        private bool HasASword { get; set; }
        public IWeapon Weapon { get; set; }

        //создание огра с мечаом или без
        public Ogre(bool hasASword):base()
        {
            HasASword = hasASword;
            if (hasASword)
            {
                Weapon = new Sword();
                Range = Weapon.Length;
                
            }
            else
            {
                
                Weapon = new Unarmed();
                Range = Weapon.Length;
            }

            CurrentHealth = 100;
            Strength = 20;
            Agility = 5;
            MaxHealth = 100;
            Mana = 0;
            MaxDamage = 4;

            
        }
        public int SwingWithSword()
        {
            int damage = r.Next(Weapon.MinDamage, Weapon.MaxDamage);
            if (HasASword)
            {
                return damage;
            }
            else
            {
                return r.Next(1, MaxDamage);
            }
        }

        public void Hit(Creature opponent)
        {
            double[] coord = { PositionX - opponent.PositionX, PositionY - opponent.PositionY, PositionZ - opponent.PositionZ };
            double distance = Distance(coord);
            if (distance > Range)
            {
                ApproachTo(opponent);
            }
            else
            {
                opponent.CurrentHealth -= SwingWithSword();
            }
        }
    }
}
