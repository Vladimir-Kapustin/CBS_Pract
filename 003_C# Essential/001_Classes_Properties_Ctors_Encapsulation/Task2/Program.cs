using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10);

            Console.WriteLine("The Perimeter is - {0}\nThe Area is - {1}", 
                rectangle.Perimeter, rectangle.Area);
        }
    }
}
