using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;
            string range = number >= 0 & number <= 14 ? "[0 - 14]" : number >= 15 & number <= 35 ? "[15 - 35]" : number >= 36 & number <= 50 ? "[36 - 50]" : "не задан";
            Console.WriteLine("Ваше число - {0}", number);    
            Console.WriteLine("Диапазон для указанного числа: {0}", range);
            Console.ReadKey();
        }
    }
}
