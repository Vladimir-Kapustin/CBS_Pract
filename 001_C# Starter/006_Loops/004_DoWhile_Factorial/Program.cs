using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_DoWhile_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            int factorial = 1;
            int counter = 1;

            do
            {
                factorial *= counter++;
            } while (counter <= N);

            Console.WriteLine("The sum of possible variants of delivery is: {0:N}", factorial);

            // Delay
            Console.ReadKey();
        }
    }
}
