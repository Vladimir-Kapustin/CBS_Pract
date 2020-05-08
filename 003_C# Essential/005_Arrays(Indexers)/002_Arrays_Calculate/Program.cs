using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Arrays_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of elements?");

            ArrayProcess array = new ArrayProcess(Int32.Parse(Console.ReadLine()));

            array.MaxMin();
            array.SumAverage();
            array.Odds();

            Console.ReadKey();
        }
    }
}
