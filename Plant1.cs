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
        
    }
    public class Tree : Plant
    {
        public bool hvoa = false;
        public int radius = 0;
        public override String GetInfo()
        {            String str = "Дерево\n" +
                "Радиус: " + radius + "\n" +
                "Тип: ";
            if (hvoa) { str +="Хвойное"; }
            else { str += "Листовое"; }
            return str;
        }
       
    }

}
