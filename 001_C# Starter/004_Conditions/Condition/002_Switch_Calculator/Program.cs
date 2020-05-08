using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Calculator: Using of different arithmetical operations (+,-,*,/)-----");
            int operand1 = 12;
            int operand2 = 0;
            Console.WriteLine("Here`s your variables:");
            Console.WriteLine(operand1);
            Console.WriteLine(operand2);
            Console.WriteLine("Insert the sign of arithmetical operation (+,-,*,/)");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", operand1, operand2, operand1 + operand2);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", operand1, operand2, operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}", operand1, operand2, operand1 * operand2);
                    break;
                case "/":
                    if (operand2==0)
                        Console.WriteLine("ERROR: Dividing by zero. Change value and try again.");
                    else
                        Console.WriteLine("{0} / {1} = {2}", operand1, operand2, (double)operand1 / (double)operand2);
                    break;
                default:
                    Console.WriteLine("There`s no such arithmetical operation here. Try again.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
