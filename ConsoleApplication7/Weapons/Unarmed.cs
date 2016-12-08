using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapons
{
    //без оружия
    class Unarmed:IWeapon
    {
        private double armLength=0.75;
        private int minDamage=1;
        private int maxDamage=2;

        public double Length
        {
            get
            {
                return armLength;
            }
        }

        public int MinDamage
        {
            get
            {
                return minDamage;
            }
        }

        public int MaxDamage
        {
            get
            {
                return maxDamage;
            }
        }
    }
}
