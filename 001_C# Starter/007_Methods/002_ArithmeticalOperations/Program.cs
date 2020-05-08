using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first number:");
            string first = Console.ReadLine();
            int a = Int32.Parse(first);

            Console.WriteLine("Insert second number:");
            string second = Console.ReadLine();
            int b = int.Parse(second);

            Console.WriteLine("Choose operation: +, -, * or /");
            string choose = Console.ReadLine();

            switch (choose)
            {
                case "+":
                    Add(a, b);
                    break;
                case "-":
                    Sub(a, b);
                    break;
                case "*":
                    Mul(a,b);
                    break;
                case "/":
                    Div(a, b);
                    break;
                default:
                    Console.WriteLine("Choose correct!");
                    break;
            }
            // Delay
            Console.ReadKey();
        }
        static void Add(int x, int y)
        {
            Console.WriteLine("The Sum is: {0}", x+y);
        }
        static void Sub(int x, int y)
        {
            Console.WriteLine("The Difference is: {0}", x - y);
        }
        static void Mul(int x, int y)
        {
            Console.WriteLine("The Product is: {0}", x * y);
        }
        static void Div(int x, int y)
        {
            if (y==0)
            {
                Console.WriteLine("Division by zero!");
            }
            else
            {
                Console.WriteLine("The Quotient is: {0}", (double)x / y);        
            }
        }
    }
}
