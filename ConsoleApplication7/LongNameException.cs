using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstApplication
{
    //собственный класс исключнений, вызывается в фабрике персонажей
    class LongNameException : ApplicationException
    {
        public override string Message
        {
            get { return "Character's name must be less than 10 characters"; }
        }
    }
}
