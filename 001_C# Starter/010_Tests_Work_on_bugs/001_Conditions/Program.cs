using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            int c = a == b-- ? 1 : 0;
            Console.WriteLine(c);

            //int a = 1, b = 3;
            //int c = a++ <= b ? a : b;
            //Console.WriteLine(c);

            // Delay
            Console.ReadKey();

            Verify();
            // Delay
            Console.ReadKey();

        }
        static void Verify ()
        {
            int x = 2;
            int y = 3;
            if (++x==y)
            {
                Console.WriteLine("Yes");
            }
            x = 2;
            if (x++==y)
            {
                Console.WriteLine("No");
            }
        }
    }
}
