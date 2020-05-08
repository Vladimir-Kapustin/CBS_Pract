using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_NumberTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            IsNegative(number);
            IsSimple(number);
            DivideWithoutReminder(number);

            //Delay
            Console.ReadKey();
        }

        // Questions:
        #region Is Number is Negative?
        static void IsNegative(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is positive");
            }
        }
        #endregion

        #region Is Number is Simple Value?
        static void IsSimple(int number)
        {
            int absValue = Math.Abs(number);

            for (int i = 2; i < absValue; i++)  // С этим условием автоматически числа 2 и 1 попадают в простые.
            {
                if (number % i == 0)
                {
                    Console.WriteLine("The number is not simple");
                    return;
                }
            }
            Console.WriteLine("The number is simple");
        }
        #endregion

        #region Can Divide by 2,5,3,6,9 without remainder?
        static void DivideWithoutReminder(int number)
        {
            bool x = false;
            if (number % 2 == 0)
            {
                Console.WriteLine("The number can be devided by 2");
                x = true;
            }
            if (number % 3 == 0)
            {
                Console.WriteLine("The number can be devided by 3");
                x = true;
            }
            if (number % 5 == 0)
            {
                Console.WriteLine("The number can be devided by 5");
                x = true;
            }
            if (number % 6 == 0)
            {
                Console.WriteLine("The number can be devided by 6");
                x = true;
            }
            if (number % 9 == 0)
            {
                Console.WriteLine("The number can be devided by 9");
                x = true;
            }
            if (x == false)
            {
                Console.WriteLine("The number can`t be devided by 2,3,5,6,9");
            }
        }
        #endregion
    }
}
