using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Lambda_Operators
{
    public delegate double MyDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate operation = null;

            Console.WriteLine("insert 2 numbers:");
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());

            Console.WriteLine("insert operation: +, -, *, /");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+": operation = (x, y) => x + y;              //lambda-expressions
                    break;
                case "-": operation = (x, y) => x - y;
                    break;
                case "*": operation = (x, y) => x * y;
                    break;
                case "/": operation = (x, y) =>                     //..operator
                {
                    if (y == 0)
                    {
                        Console.WriteLine("You trying to divide by zero!");
                        return 0;
                    }
                    else
                    {
                        return x / (double) y;
                    };
                };
                    break;
                default: Console.WriteLine("no such operation");
                    break;
            }

            if (operation == null)
            {

            }
            else
            {
                Console.WriteLine("{0:##.###}", operation(one, two));
            }

            Console.ReadKey();
        }
    }
}
