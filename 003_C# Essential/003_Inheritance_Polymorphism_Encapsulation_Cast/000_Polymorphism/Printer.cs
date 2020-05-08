using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Polymorphism
{
    class Printer
    {
        public virtual void Print (string value)
        {
            Console.ForegroundColor = ConsoleColor.Gray; //Задает цвет текста консоли.
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
