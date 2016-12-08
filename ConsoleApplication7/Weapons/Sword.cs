
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapons
{
    sealed class Sword : Weapon
    {
        
        public Sword()
        {
            _length = 1.5;
            _minDamage = 1;
            _maxDamage = 6;
        }
    }
}
