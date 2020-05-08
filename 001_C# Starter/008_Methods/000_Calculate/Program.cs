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
            int i = 5, j = 10, k = 15;
            Calculate(i, j, k);
            // Delay
            Console.ReadKey();
        }
        static void Calculate(int x, int y, int z)
        {
            Console.WriteLine("X/5 : {0}", x / 5);
            Console.WriteLine("Y/5 : {0}", y / 5);
            Console.WriteLine("Z/5 : {0}", z / 5);
        }
    }
}
