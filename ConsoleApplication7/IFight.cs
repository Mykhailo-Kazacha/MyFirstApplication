using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstApplication
{
    //интерфейс, говорящий о том, что кто-то может наносить удары
    interface IFight
    {
        void Hit(Creature opponent);
    }
}
