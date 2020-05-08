using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_ReversedArrayAndSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert array length");
            int n = int.Parse(Console.ReadLine());

            // Создание массива, и заполнение случайными числами.
            int[] array = new int[n];
            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
            }

            // Печать массива на экран
            Console.WriteLine("Your array is:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            // Перевёрнутый массив. Вывод.
            Console.WriteLine("\nReversed array is:");
            int[] reversed = MyReverse(array);
            for (int i = 0; i < reversed.Length; i++)
            {
                Console.Write("{0} ", reversed[i]);
            }

            Console.WriteLine("\n\nInsert index of element from which the new array will begin:");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInsert length of the new array:");
            int length = int.Parse(Console.ReadLine());

            // Подмассив. Вывод.
            Console.WriteLine("Sub array is:");
            int[] sub = SubArray(array, index, length);
            for (int i = 0; i < sub.Length; i++)
            {
                Console.Write("{0} ", sub[i]);
            }

            //Delay
            Console.ReadKey();
        }

        #region Переворачивание массива
        static int[] MyReverse(int[] array)
        {
            int[] output = new int[array.Length];
            int counter = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                output[counter] = array[i];
                counter++;
            }
            return output;
        }
        #endregion

        #region Создание и вывод подмассива
        static int[] SubArray(int[] array, int index, int count)
        {
            int[] output = new int[count];
            int counter = 0;
            for (int i = index; i < (index + count) & i < array.Length; i++)
            {
                output[counter] = array[i];
                counter++;
            }
            return output;
        }
        #endregion
    }
}