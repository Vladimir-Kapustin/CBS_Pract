using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Arrays_Calculate
{
    class ArrayProcess
    {
        int[] array;
        public ArrayProcess (int number) 
        {
            array = new int[number];
            // filling
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(99);
            }
        }

        public void MaxMin()
        {
            int max=0;
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Max is {0}", max);
            Console.WriteLine("Min is {0}", min);
        }

        public void SumAverage()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Sum is {0}", sum);
            Console.WriteLine("Average is {0}", (double)sum/array.Length);
        }

        public void Odds()
        {
            Console.WriteLine("Odds are:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
