using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Маразм

namespace Methods
{
    class Program
    {
        static void Repay()
        {
            Repay(0, 0, 0, 0, 0, 0, 0);
        }
        static void Repay(int first)
        {
            Repay(first, 0, 0, 0, 0, 0, 0);
        }
        static void Repay(int first, int second)
        {
            Repay(first, second, 0, 0, 0, 0, 0);
        }
        static void Repay(int first, int second, int third)
        {
            Repay(first, second, third, 0, 0, 0, 0);
        }
        static void Repay(int first, int second, int third, int fourth)
        {
            Repay(first, second, third, fourth, 0, 0, 0);
        }
        static void Repay(int first, int second, int third, int fourth, int fifth)
        {
            Repay(first, second, third, fourth, fifth, 0, 0);
        }
        static void Repay(int first, int second, int third, int fourth, int fifth, int sixth)
        {
            Repay(first, second, third, fourth, fifth, sixth, 0);
        }
        static void Repay(int first, int second, int third, int fourth, int fifth, int sixth, int seventh)
        {
            int repayment = 700 - first - second - third - fourth - fifth - sixth - seventh;
            if (repayment > 0)
                Console.WriteLine("Rest: {0}", repayment);
            else if (repayment < 0)
                Console.WriteLine("Overpaid: {0}", repayment - repayment * 2);
            else
                Console.WriteLine("Credit was repaid!");
        }
        static void Main(string[] args)
        {
            Repay();
            Repay(100, 100, 100, 100, 100, 100, 100);
            Repay(300, 400);
            Repay(200, 300);
            Repay(700, 700);
            // Delay
            Console.ReadKey();
        }
    }
}
