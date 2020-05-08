using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Замените в коде условную конструкцию if на тернарный оператор таким образом, чтобы поведение программы осталось таким же.
namespace _3_5_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 32;
            int min;

            min = (a < b) ? a : b;
        }
    }
}
