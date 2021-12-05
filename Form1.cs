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
                        this.ListOfPlants.Add(new Tree {
                            Hight = rnd.Next(50,500)
                        });
                        
                        break;
                    case 1:
                        this.ListOfPlants.Add(new Bush
                        {
                            Hight = rnd.Next(20, 50),
                            vetki = rnd.Next(5, 16),
                            flovers = rnd.Next(1) == 0
                        }) ;
                        break;
                    case 2:
                        string[] names = new string[] {"Голубой","Желтый","Красный", "Белый" };
                        string[] types = new string[] { "Лиллия", "Одуванчик" };
                        this.ListOfPlants.Add(new Flover {
                            Hight = rnd.Next(1, 20),
                            Lepestki = rnd.Next(3, 8),
                            Color = names[rnd.Next(3)],
                            Type = types[rnd.Next(1)]
                        }); 
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
            var plant = this.ListOfPlants[0];
            this.ListOfPlants.RemoveAt(0);

            txtOut.Text = plant.GetInfo();

            pictureBox.Image = Image.FromFile(plant.GetImage());
            ShowInfo();
        }
    }
}
