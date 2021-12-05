using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Nasledovanie
{
    public partial class Form1 : Form
    {
        List<Plant> ListOfPlants = new List<Plant>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        

        private void Refull_Click(object sender, EventArgs e)
        {
            this.ListOfPlants.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0: 
                        this.ListOfPlants.Add(new Tree());
                        break;
                    case 1: 
                        this.ListOfPlants.Add(new Bush());
                        break;
                    case 2: 
                        this.ListOfPlants.Add(new Flover());
                        break;
                      
                }
            }
            ShowInfo();
        }
        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int TreeCount = 0;
            int BushCount = 0;
            int FloverCount = 0;

            // пройдемся по всему списку
            foreach (var fruit in this.ListOfPlants)
            {
                if (fruit is Tree)
                {
                    TreeCount += 1;
                }
                else if (fruit is Bush)
                {
                    BushCount += 1;
                }
                else if (fruit is Flover)
                {
                    FloverCount += 1;
                }
            }

            CountOf.Text = String.Format("{0}\n{1}\n{2}", TreeCount, BushCount, FloverCount);
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            // если список пуст, то напишем что пусто и выйдем из функции
            if (this.ListOfPlants.Count == 0)
            {
                txtOut.Text = "Пусто";
                pictureBox.Image = Image.FromFile("pusto");
                return;
            }
            var drink = this.ListOfPlants[0];
            this.ListOfPlants.RemoveAt(0);

            txtOut.Text = drink.GetInfo();

            pictureBox.Image = drink.GetJPG();
            ShowInfo();
        }
    }
}
