using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ClassCtorProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 10);

            Console.WriteLine("The Perimeter is {0}\nThe Area is {1}", rect.Perimeter, rect.Area);
            Console.ReadKey();
        }
    }
}
