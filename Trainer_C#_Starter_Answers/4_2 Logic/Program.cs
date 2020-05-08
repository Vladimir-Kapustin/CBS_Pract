using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите в редакторе кода результат выполнения следующей программы (результат писать в десятеричной системе счисления!):

namespace _4_2_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5, b = 8;

            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(a ^ b);
        }
    }
/*Ответ:
0
13
13
*/
}
