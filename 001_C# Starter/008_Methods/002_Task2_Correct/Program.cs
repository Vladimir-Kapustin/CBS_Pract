using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Task2_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert amount of debt");
            int debt = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert amount of payment");
            int payment = int.Parse(Console.ReadLine());

            CalculateRepayment(ref debt, payment);
        }

        static void CalculateRepayment(ref int debt, int payment)
        {
            debt = debt - payment;

            if (debt > 0)
            {
                Console.WriteLine("Remaining debt is: {0}", debt);
            }
            else if (debt < 0)
            {
                Console.WriteLine("Overpayment is: {0}. The debt is rapaid.", ~debt + 1);
            }
            else
            {
                Console.WriteLine("The debt is repaid");
            }
        }
    }
}
