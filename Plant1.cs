using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Nasledovanie
{
    public class Plant
    {
        public static Random rnd = new Random();
        public int Hight=0;
        public virtual String GetInfo()
        {
            String str = "Растение";
            return str;
        }
        public virtual String GetImage()
        {
            return "pusto";
        }
    }
    public class Flover : Plant
    {
        public int Lepestki = 0;
        public String Color = "";
        public String Type = "";
        public override String GetInfo()
        {
            String str = "Цветок\n" +
                "Количество лепестков: "+Lepestki+"\n" +
                "Цвет: "+Color+"\n" +
                "Тип: "+Type;
            return str;
        }
        public override String GetImage()
        {
            String Image;
            switch (Type)
            {
                case "Одуванчик":
                    { Image = "Oduvanchik"; }
                    break;
                case "Лиллия":
                    {
                        Image = "Lilia";
                    }
                    break;
                default:
                    {
                        Image = "pusto";
                        break;
                    }
            }
            return Image;
        }
    }

    public class Bush : Plant
    {
        public bool flovers = false;
        public int vetki = 0;
        public override String GetInfo()
        {
            String str = "Куст\n" +
                    "Количество веток: " + vetki + "\n" +
                    "Наличие цветов: " + flovers;
            return str;
        }
        public override String GetImage()
        {
            String Image;
            if (flovers) {
                Image = "FloverBush";
            }
            else
            {
                Image = "Bush";
            }
            return Image;
        }
    }
    public class Tree : Plant
    {
        public String type = "";
        public int radius = 0;
        public override String GetInfo()
        {
            String str = "Дерево\n" +
                "Радиус: " + radius + "\n" +
                "Тип: " + type;
            return str;
        }
        public override String GetImage()
        {
            String Image;
            switch (type)
            {
                case "Хвойное":
                    { Image = "Hvoia"; }
                    break;
                case "Листовое":
                    {
                        Image = "List";
                    }
                    break;
                default:
                    {
                        Image = "pusto";
                        break;
                    }
            }
            return Image;
        }
    }

}
