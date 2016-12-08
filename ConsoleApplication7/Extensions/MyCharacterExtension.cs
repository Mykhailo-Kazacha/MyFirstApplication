using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFirstApplication;

namespace MyExtensions
{
    //экстеншн-метод для класса Creature. Сделан для примера
    public static class MyCharacterExtension
    {
        public static void Shout(this Creature @char)
        {
            
            System.Windows.Forms.MessageBox.Show("AAAAAA!!!!!!");
        }
    }
}
