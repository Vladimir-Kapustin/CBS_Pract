using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Найдите и исправьте ошибки в коде, который использует именованные параметры
namespace _7_2_Methods_Recursion
{
    class Program
    {
        static string FormatString(string s, int number)
        {
            return String.Format("{0}: {1};", s, number);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FormatString(number: 5, s: "Number"));
            Console.ReadKey();
        }
    }
}
