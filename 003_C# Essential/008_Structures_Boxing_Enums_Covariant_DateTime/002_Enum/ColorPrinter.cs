using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Enum
{
    public static class ColorPrinter
    {
        public static void Print(string stroka, int color)
        {
           switch (color)
           {
                case (int)EnumColor.blue: Console.ForegroundColor = ConsoleColor.Blue;
                   break;
                case (int)EnumColor.black: Console.ForegroundColor = ConsoleColor.Black;
                   break;
                case (int)EnumColor.red: Console.ForegroundColor = ConsoleColor.Red;
                   break;
                case (int)EnumColor.green: Console.ForegroundColor = ConsoleColor.Green;
                   break;
                case (int)EnumColor.yellow: Console.ForegroundColor = ConsoleColor.Yellow;
                   break;
                case (int)EnumColor.magenta: Console.ForegroundColor = ConsoleColor.Magenta;
                   break;
                default: Console.WriteLine("No such color");
                   break;
           }
            Console.WriteLine(stroka);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
