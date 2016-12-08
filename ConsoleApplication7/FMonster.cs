using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MyExtensions;
using Characters;
using Monsters;

namespace MyFirstApplication
{
    public partial class FMonster : Form
    {
        private FCharacter characterForm;

        private Character character;

        //метод, вызывающийся когда персонаж кого-то убивает
        private void DisplayWinner(string message)
        {
            listBox1.Items.Add(message);
        }

        //метод, вызывающийся когда персонажа убивают
        private void DisplayLoser(string message)
        {
            listBox1.Items.Add(message);
        }

        //имитация боя. ПРИМЕЧАНИЕ: возможно следует переписать логику
        private static void Fight(Creature fighter1, Creature fighter2)
        {
            bool fighter1CanHit = true, fighter2CanHit = false;
            IFight fighter11 = fighter1 as IFight;
            IFight fighter22 = fighter2 as IFight;
            if (fighter11 != null && fighter22 != null)
            {

                while (true)
                {
                    if (fighter1CanHit)
                    {

                        fighter11.Hit(fighter2);
                        if (fighter2.CurrentHealth<=0)
                        {
                            if (fighter2 is Character)
                            {
                                ((Character)fighter2).OnDeath("Your Swordsman has died!!!");
                            }
                            break;
                        }
                        else
                        {
                            fighter1CanHit = !fighter1CanHit;
                            fighter2CanHit = !fighter2CanHit;
                        }

                        
                    }
                    if (fighter2CanHit)
                    {
                        fighter22.Hit(fighter1);
                        if (fighter1.CurrentHealth<=0)
                        {
                            if (fighter1 is Character)
                            {
                                ((Character)fighter1).OnDeath("Your Swordsman has died!!!");
                            }
                            fighter1.Shout();
                            break;
                        }
                        else
                        {
                            fighter2CanHit = !fighter2CanHit;
                            fighter1CanHit = !fighter1CanHit;
                        }
                    }
                }
            }
        }
        public FMonster(Form charForm,Character character)
        {
            InitializeComponent();
            characterForm = (FCharacter)charForm;

            //считывание статов из файла и вывод их на экран
            this.character = character;
            using (StreamReader reader = File.OpenText("Stats.txt"))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    listBox2.Items.Add(line);
                }
            }

            //добавление событий персонажу
            character.Kill += DisplayWinner;
            character.Death += DisplayLoser;

        }

        private void rBOgre_CheckedChanged(object sender, EventArgs e)
        {
            cBOgreSword.Enabled = !cBOgreSword.Enabled;
        }

        private void bStartFight_Click(object sender, EventArgs e)
        {
            Monster monster;

            //создание монстра. стоит в будущем перенести в фабрику монстров
            if (rBOgre.Checked)
            {
                monster = new Ogre(cBOgreSword.Checked);
            }
            else
            {
                if (rBWitch.Checked)
                {
                    monster = new Witch();
                }
                else
                {
                    monster = new Imp();
                }
            }

            //имитация 10 сражений
            for (int i=0;i<10;i++)
            {
                Fight(character,monster);
                listBox1.Items.Add(String.Format("character's health - {0}, monster's health - {1}", character.CurrentHealth,
                monster.CurrentHealth));
                character.CurrentHealth = character.MaxHealth;
                monster.CurrentHealth = monster.MaxHealth;
            }

            

        }

        private void FMonster_FormClosed(object sender, FormClosedEventArgs e)
        {
            characterForm.Close();
        }
    }
}
