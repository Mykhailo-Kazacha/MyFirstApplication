using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstApplication
{
    //интерфейс, обеспечивающий работу с луком
    interface IHaveABow
    {
        int SwingWithWeapon();
        void SwitchWeapons();
    }
}
