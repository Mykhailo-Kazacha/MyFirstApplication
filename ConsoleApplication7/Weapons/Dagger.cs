using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapons
{
    sealed class Dagger : Weapon
    {
        public Dagger()
        {
            _length = 1;
            _minDamage = 1;
            _maxDamage = 4;
        }
    }
}
