using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Collection_Array_yield
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int [] { 1, 3, 42, 54, 63, 71, 9, 16, 5, 10 };

            foreach (var item in UserCollection.Power(array))  // для названий методов используй более подходящие названия - то что они делают
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
