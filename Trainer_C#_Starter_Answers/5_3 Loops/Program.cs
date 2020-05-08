using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//После объявления переменной counter напишите цикл с предусловием так, чтобы пока counter > 2, в консоль с новой строки выводилось «Counter больше 2», и после этого с помощью оператора декремента значение counter уменьшалось на единицу.
namespace _5_3_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 8;
            while (counter > 2)
            {
                Console.WriteLine("Counter больше 2");
                counter--;
            }
        }
    }
}
