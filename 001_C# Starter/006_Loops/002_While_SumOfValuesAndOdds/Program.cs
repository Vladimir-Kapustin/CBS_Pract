using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5;
            int B = 20;
            int sum = 0;

            while (A < B - 1)
            {
                sum += ++A;
            }
            Console.WriteLine("sum is {0}", sum);

            A = 5;
            while (A < B)
            {
                if (A % 2 == 0)
                {
                    Console.WriteLine(A);
                }
                A++;
            }
            Console.ReadKey();
        }
    }
}
