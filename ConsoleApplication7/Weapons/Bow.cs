using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapons
{
    sealed class Bow : Weapon
    {
        public int NumberOfArrows { get; set; }
        public Bow()
        {
            _length = 100;
            _minDamage = 1;
            _maxDamage = 4;
            NumberOfArrows = 10;
        }
    }
}
