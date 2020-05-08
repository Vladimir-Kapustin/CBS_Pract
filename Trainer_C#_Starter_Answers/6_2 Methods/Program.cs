using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Что выведет на экран данный код?

namespace _7_2_Methods
{
    class Program
    {
        static void DecrementArguments(int arg1, ref int arg2)
        {
            arg1--;
            --arg2;
        }

        static void Main(string[] args)
        {
            int a = 5, b = 9;
            DecrementArguments(a, ref b);
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }
    }
    /* Ответ:
5 8
     */
}
