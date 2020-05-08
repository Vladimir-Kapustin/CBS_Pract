using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_MaxMinAverageOddElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert array length");
            int n = int.Parse(Console.ReadLine());

            // Создание и заполнение массива
            int[] array = new int[n];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
            }

            // Вывод на экран
            Console.WriteLine("\nYour array is:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            int max = 0;
            int min = array[1]; // если инициализировать нулём - то нуль и будет минимальным, а не какое-то значение массива :)
            int sum = 0;

            Console.WriteLine("\n\nOdds are:");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) //поиск нечётных
                {
                    Console.WriteLine(array[i]);
                }
                if (array[i] > max)   //максимум
                {
                    max = array[i];
                }
                if (array[i] < min) //миимум
                {
                    min = array[i];
                }

                sum += array[i];    //общая сумма. среднее - вычисляется после цикла.
            }

            Console.WriteLine("\nMaximum element is: {0}", max);
            Console.WriteLine("\nMinimum element is: {0}", min);
            Console.WriteLine("\nSum of elements is: {0}", sum);
            Console.WriteLine("\nArithmetical Average is: {0}", (double)sum / array.Length);

            // Delay
            Console.ReadKey();
        }
    }
}
