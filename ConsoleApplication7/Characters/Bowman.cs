using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weapons;
using MyFirstApplication;

namespace Characters
{
    //представляет класс лучника с основным оружием Лук и запасным Кинжал
    class Bowman : Character, IHaveABow, IFight
    {
        private Weapon _secondaryWeapon;

        public Bowman(string name, Races race) : base(race)
        {
            if (name.Length > 10)
            {
                LongNameException e = new LongNameException();
                throw e;
            }
            else
            {
                Name = name;
            }

            Weapon = new Bow();
            _secondaryWeapon = new Dagger();
            
        }

        //метод имитирующий выстрел из лука. Возвращает нанесенный урон.
        private int FireWithABow()
        {
            int damage = r.Next(Weapon.MinDamage, Weapon.MaxDamage);
            switch (Race)
            {
                case Races.elf:
                    return damage + 2;
                case Races.human:
                    return damage;
                case Races.orc:
                    return damage - 2;
            }
            return damage;
        }

        //смена оружия если враг близко или кончились стрелы
        public void SwitchWeapons()
        {
            Weapon = _secondaryWeapon;
        }
        //удар кинжалом
        private int SwingWithDagger()
        {
            int damage = r.Next(Weapon.MinDamage, Weapon.MaxDamage);
            switch (Race)
            {
                case Races.elf:
                    return damage;

                case Races.human:
                    return damage;
                case Races.orc:
                    return damage +1;
            }
            return damage;
        }

        //удар текущим оружием. ПРИМЕЧАНИЕ: возможно, есть смысл поместить этот метод в IWeapon, реализовать в каждом классе,
                                                                                            //передавая в параметры расу/перса
        public int SwingWithWeapon()
        {
            if (Weapon is Bow)
            {
                return FireWithABow();
            }
            else
            {
                return SwingWithDagger();
            }
        }

        //выводит данные о персонаже
        public override void DisplayStats()
        {
            base.DisplayStats();
        }

        //моделирует ход: выстрел, смену оружия, удар. ПРИМЕЧАНИЕ: возможно следует переписать логику получше
        public void Hit(Creature opponent)
        {
            double[] coord = { PositionX-opponent.PositionX, PositionY - opponent.PositionY, PositionZ - opponent.PositionZ };
            double distance = Distance(coord);
            if (distance > Weapon.Length)
            {
                ApproachTo(opponent);
            }
            else
            {
                if (distance > 2 && this.Weapon is Bow)
                {
                    opponent.CurrentHealth -= SwingWithWeapon();
                    ((Bow)Weapon).NumberOfArrows--;
                    if (((Bow)Weapon).NumberOfArrows == 0)
                    {
                        SwitchWeapons();
                    }
                }
                else
                {
                    if (distance <= 2 && Weapon is Bow)
                    {
                        SwitchWeapons();
                    }
                    else {
                        if (distance > Weapon.Length && Weapon is Dagger)
                        {
                            ApproachTo(opponent);
                        }
                        else
                        {
                            opponent.CurrentHealth -= SwingWithWeapon();
                        }
                    }
                }
                if (opponent.CurrentHealth <= 0)
                {
                    OnKill("Your Bowman has won!!!");
                }
                if (CurrentHealth <=0)
                {
                    OnDeath("Your Bowman has died!!!");
                }
            }
        }
        //переопределение события
        protected override void OnKill(string message)
        {
            base.OnKill(message);
        }

        public override void OnDeath(string message)
        {
            base.OnDeath(message);
        }
    }
}
