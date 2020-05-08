using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(50);
            }

            int[] sortedArray = array.Sort();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }

            Console.ReadKey();
        }
    }
}
