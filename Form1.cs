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
            RefullOption();
            ShowInfo();
        }

        private void RefullOption()
        {
            this.ListOfPlants.Clear();
            var rnd = new Random();

            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0:
                        this.ListOfPlants.Add(new Tree
                        {
                            Hight = rnd.Next(50, 1000),
                            radius = rnd.Next(10, 300),
                            hvoa = rnd.Next(1) == 0
                        });

                        break;
                    case 1:
                        this.ListOfPlants.Add(new Bush
                        {
                            Hight = rnd.Next(20, 50),
                            vetki = rnd.Next(5, 16),
                            flovers = rnd.Next(2) == 0
                        });
                        break;
                    case 2:
                        string[] names = new string[] { "Голубой", "Желтый", "Красный", "Белый" };
                        string[] types = new string[] { "Лиллия", "Роза", "Анютины глазки" };
                        this.ListOfPlants.Add(new Flover
                        {
                            Hight = rnd.Next(1, 20),
                            Lepestki = rnd.Next(3, 8),
                            Color = names[rnd.Next(4)],
                            Type = types[rnd.Next(3)]
                        });
                        break;
                }
            }
        }

        private void Refull_Click(object sender, EventArgs e)
        {
            RefullOption();
            ShowInfo();
        }
        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int TreeCount = 0;
            int BushCount = 0;
            int FloverCount = 0;
            String str= "";
            int L = 0;

            // пройдемся по всему списку
            foreach (var fruit in this.ListOfPlants)
            {
                if (fruit is Tree)
                {
                    TreeCount += 1;
                    str += (L+1)+") Дерево\n";
                }
                else if (fruit is Bush)
                {
                    BushCount += 1;
                    str += (L + 1) + ") Куст\n";
                }
                else if (fruit is Flover)
                {
                    FloverCount += 1;
                    str += (L + 1) + ") Цветок\n";
                }
                L += 1;
            }
            Ochered.Text = str;
            CountOf.Text = String.Format("{0}\n{1}\n{2}", TreeCount, BushCount, FloverCount);
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            // если список пуст, то напишем что пусто и выйдем из функции
            if (this.ListOfPlants.Count == 0)
            {
                txtOut.Text = "Пусто";
                return;
            }
            var plant = this.ListOfPlants[0];
            this.ListOfPlants.RemoveAt(0);

            txtOut.Text = plant.GetInfo();
            ShowInfo();
        }
    }
}
