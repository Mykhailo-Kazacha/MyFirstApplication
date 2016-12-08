using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Characters;
using MyFirstApplication;

namespace Factories
{
    //фабрика по производству персонажей. Лучше было сделать с применением интерфейса ICharacter,
                            //но я обнаружил, что от него мне не надо практически никакие свойства, поэтому решил его не вводить
    public class CharacterFactory
    {
        public Character CreateCharacter(string name, string race, string weapon)
        {
            //определение расы
            Races charRace;
            switch (race)
            {
                case "Human": charRace = Races.human;
                    break;
                case "Elf":
                    charRace = Races.elf;
                    break;
                case "Orc":
                    charRace = Races.orc;
                    break;
                default:
                    charRace = Races.human;
                    break;
            }

            //определение оружия и создание в соответствии с ним персонажа. может выбросить исключение LongNameException
                                                                            //(только для лучника) если имя длинее 10 символов
            switch (weapon)
            {
                case "Sword": return new Swordsman(name, charRace);
                case "Bow and dagger":
                    try
                    {
                        return new Bowman(name, charRace);
                    }
                    catch (LongNameException e)
                    {
                        MessageBox.Show(e.Message);
                        return new Bowman("Noname",charRace);
                    }
                    finally
                    {
                        
                    }
                default: return new Swordsman();
            }
        }

        public Character CreateCharacter()
        {
            return new Swordsman();
        }
    }
}
