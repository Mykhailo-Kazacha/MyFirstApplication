using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weapons
{
    //интерфейс оружия
    public interface IWeapon
    {
        double Length { get;}
        int MinDamage { get; }

        int MaxDamage { get; }
    }
}
