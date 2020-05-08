using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//После объявления переменной month_number допишите условный оператор if-else, который будет делать следующее:
//Если значение переменной лежит в диапазоне от 6 до 8 включительно, то вывести в консоль с новой строки "Лето", иначе – вывести "Другое время года".

namespace _4_4_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int month_number = 7;
            if (month_number >= 6 && month_number <= 8)
            {
                Console.WriteLine("Лето");
            }
            else
            {
                Console.WriteLine("Другое время года");
            }
        }
    }
}
