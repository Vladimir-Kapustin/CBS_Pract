using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//После объявления переменной letter допишите оператор выбора вариантов, который будет делать следующее:
//если в letter хранится значение ‘a’ – тогда вывести в консоль строку "Первая буква английского алфавита"; если значение ‘b’ – вывести "Вторая буква английского алфавита"; иначе – вывести "Другая буква". Для вывода на консоль используйте метод WriteLine

namespace _3_3_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'b';
            switch (letter)
            {
                case 'a':
                    {
                        Console.WriteLine("Первая буква английского алфавита");
                        break;
                    }
                case 'b':
                    {
                        Console.WriteLine("Вторая буква английского алфавита");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Другая буква");
                        break;
                    }
            }
        }
    }
}
