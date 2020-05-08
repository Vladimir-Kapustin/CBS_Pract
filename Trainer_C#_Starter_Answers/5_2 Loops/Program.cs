using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Найдите и исправьте ошибки в коде, который рисует в левом верхнем углу консоли следующий прямоугольный треугольник с помощью символов “#”:

#####
####
###
##
#
 */
namespace _5_2_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 5;
            for (int i = 0; i < length; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
