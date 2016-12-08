using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Characters;
using Factories;
using Weapons;

namespace MyFirstApplication
{
    public partial class FCharacter : Form
    {
        private Party<Character> party = new Party<Character>();
        
        //персонаж, создающийся на форме, передается во вторую форму        
        private Character character;

        private FMonster monsterForm;

        private void CharacterCreation()
        {
            string race="";
            string weapon="";
            string name;
            //сохранение выбранной расы
            foreach (Control c in raceBox.Controls)
            {
                if (((RadioButton)c).Checked)
                {
                    race = c.Text;
                }
            }
            //сохранение выбранного оружия
            foreach (Control c in weaponBox.Controls)
            {
                if (((RadioButton)c).Checked)
                {
                    weapon = c.Text;
                }
            }
            //создание фабрики и передача ей необходимых параметров
            CharacterFactory factory = new CharacterFactory();
            if (cBDefault.Checked)
            {
                character = factory.CreateCharacter();
            }
            else
            {
                name = textBox1.Text;
                character = factory.CreateCharacter(name,race,weapon);
            }

            
                   
        }

        
        public FCharacter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                CharacterCreation();

            //запись персонажа в файл. Возможно, стоит перенести в виртуальный метод персонажа типа "WriteStats"
            using (StreamWriter writer = File.CreateText(
                @"Stats.txt"))
               // @"C:\Users\Ivan\Desktop\C#\ConsoleApplication7\ConsoleApplication7\bin\Debug\Stats.txt"))
            {
                writer.WriteLine("Name = " + character.Name);
                writer.WriteLine("Race = " + character.Race);
                writer.WriteLine("Strength = " + character.Strength);
                writer.WriteLine("Agility = " + character.Agility);
                writer.WriteLine("MaxHealth = " + character.MaxHealth);
                writer.WriteLine("CurrentHealth = " + character.CurrentHealth);
                writer.WriteLine("Mana = " + character.Mana);
            }

            //создание и запуск второй формы
            monsterForm = new FMonster(this, character);
            Hide();
            monsterForm.Show();
   
        }

        private void cBDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (cBDefault.Checked)
            {
                raceBox.Enabled = false;
                weaponBox.Enabled = false;

            }
            else
            {
                raceBox.Enabled = true;
                weaponBox.Enabled = true;
            }
        }

        //добавление перса в партию
        private void bAddMemberToParty_Click(object sender, EventArgs e)
        {
            if (!cBDefault.Checked)
            {
                CharacterCreation();
                party.AddMember(character);
            }
            else
            {
                character = new Swordsman("Noname",Races.human);
                party.AddMember(character);
            }

            

        }

        
        //сохранение партии в файл
        private void bSaveParty_Click(object sender, EventArgs e)
        {
            FileInfo f = new FileInfo
                (@"C:\Users\Ivan\Desktop\C#\ConsoleApplication7\ConsoleApplication7\bin\Debug\Party.txt");
            StreamWriter sw = f.CreateText();
            foreach (Character c in party)
            {
                sw.WriteLine("Race = " + c.Race);
                sw.WriteLine("Strength = " + c.Strength);
                sw.WriteLine("Agility = " + c.Agility);
                sw.WriteLine("MaxHealth = " + c.MaxHealth);
                sw.WriteLine("CurrentHealth = " + c.CurrentHealth);
                sw.WriteLine("Mana = " + c.Mana);
                sw.WriteLine("___________________________");
            }

            FileInfo f1 = new FileInfo
                (@"C:\Users\Ivan\Desktop\C#\ConsoleApplication7\ConsoleApplication7\bin\Debug\PartyWithSwords.txt");
            StreamWriter sw1 = f1.CreateText();

 /*from, in             Используется для определения основы любого выражения LINQ,  
                            позволяющей извлечь подмножество данных из нужного контейнера
    where               Используется для определения ограничений о том, т.е.какие
                            элементы должны извлекаться из контейнера
select                  Используется для выбора последовательности из контейнера
join, on, equals, into  Выполняет соединения на основе указанного ключа. Помните, что
                            эти "соединения" ничего не делают с данными в реляционных базах
orderby, ascending,     Позволяет упорядочить результирующий набор в порядке возраста -
descending                  ния или убывания
group, by               Порождает подмножество с данными, сгруппированными по
                            указанному значению*/

            //использование LINQ to Objects просто для примера. в дальнейшем не используется.
            var subParty = from c in party.partymembers where c.Weapon is Sword select c;
            foreach (var c in subParty)
            {
                sw1.WriteLine("Race = " + c.Race);
                sw1.WriteLine("Strength = " + c.Strength);
                sw1.WriteLine("Agility = " + c.Agility);
                sw1.WriteLine("MaxHealth = " + c.MaxHealth);
                sw1.WriteLine("CurrentHealth = " + c.CurrentHealth);
                sw1.WriteLine("Mana = " + c.Mana);
                sw1.WriteLine("___________________________");
            }

            sw1.Close();
        }
    }
}
