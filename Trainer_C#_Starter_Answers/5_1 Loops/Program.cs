using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В тело метода Main() поместите цикл for, который будет выполнять итерации со значениями счетчика i типа int от 1 до 10 включительно, выводя в консоль с новой строки текст «Номер i», где i – значение счетчика. Используйте элементы форматирования.
namespace _5_1_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Номер {0}", i);
            }
        }
    }
}
