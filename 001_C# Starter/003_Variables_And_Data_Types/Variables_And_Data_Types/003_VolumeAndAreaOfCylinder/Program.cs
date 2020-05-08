using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_VolumeAndAreaOfCylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            int r = 5;
            int h = 7;                  // height
            double V = pi * (r * r) * h;
            double S = 2 * pi * r * (r + h);

            Console.WriteLine("V = {0}", V);
            Console.WriteLine("S = {0}", S);
            Console.ReadKey();
        }
    }
}
