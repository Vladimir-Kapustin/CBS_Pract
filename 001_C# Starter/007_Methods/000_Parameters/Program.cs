using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 6, z = 10;
            Calculate(x, y, z);

            // Delay
            Console.ReadKey();
        }
        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine("Average is: {0}", (a+b+c)/3);
        }
    }
}
