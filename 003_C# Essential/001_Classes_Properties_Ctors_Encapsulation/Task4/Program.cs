using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(10,20, "A"), new Point(10,30, "B"), new Point(5,15,"C"));

            figure.PerimeterCalculator();
        }
    }
}
