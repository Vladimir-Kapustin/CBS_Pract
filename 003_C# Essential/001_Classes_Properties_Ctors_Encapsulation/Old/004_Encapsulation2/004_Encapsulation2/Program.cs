using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Encapsulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(11, 12, "A"), new Point(15, 20, "B"), new Point(10, 5, "C"), new Point(20, 25, "D"));
            figure.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
