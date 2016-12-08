using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapons
{
    //Общая концепция оружия
    abstract public class Weapon:IWeapon
    {
        protected int _minDamage;
        protected int _maxDamage;
        protected double _length;
        public int MinDamage
        {
            get
            {
                return _minDamage;
            }
        }
        public int MaxDamage {
            get
            {
                return _maxDamage; 
            }
        }
        public double Length {
            get
            {
                return _length;
            }
        }
    }
}
