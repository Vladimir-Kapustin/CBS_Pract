using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_StaticClass_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(50,60));
            Console.WriteLine(Calculator.Subtract(70,50));
            Console.WriteLine(Calculator.Multiply(40, 86));
            Console.WriteLine(Calculator.Devide(250,2));

            Console.ReadKey();
        }
    }
}
