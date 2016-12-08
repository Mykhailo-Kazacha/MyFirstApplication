using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstApplication
{
    //базовый класс для персов и монстров. Содержит базовые параметры, а также положение на поле,
    //случайное ее проставление в квадрате 20х20, и вычисление дистанции до некоторой точки 
    public abstract class Creature 
    {
        protected Random r = new Random();
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int MaxHealth { get; set; }
        public int Mana { get; set; }

        public int CurrentHealth { get; set; }



        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public double PositionZ { get; set; }

        private void SetPosition()
        {
            PositionX = r.Next(20);
            PositionY = r.Next(20);
            PositionZ = 0;
        }

        public double Distance(params double[] coordinates)
        {
            double sum = 0;
            foreach (double tmp in coordinates)
            {
                sum = sum + Math.Pow(tmp, 2);
            }
            return Math.Sqrt(sum);
        }
        public Creature()
        {
            SetPosition();
            
        }

        public virtual void DisplayStats()
        {
        }
        //может сделать это интерфейсом типа ICanMove на случай неподвижных монстров
        public void ApproachTo(Creature opponent)
        {
            double[] coord = { PositionX - opponent.PositionX, PositionY - opponent.PositionY, PositionZ - opponent.PositionZ };
                PositionX -= coord[0] / Math.Sqrt(Math.Pow(coord[0], 2) + Math.Pow(coord[1], 2));
                PositionY -= coord[1] / Math.Sqrt(Math.Pow(coord[0], 2) + Math.Pow(coord[1], 2));
        }
    }
}
