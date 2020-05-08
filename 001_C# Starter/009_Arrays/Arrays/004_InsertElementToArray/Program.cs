using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_InsertElementToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert array length");       // генерация нового массива - случайными числами.
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
            }

            Console.WriteLine("Array before:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            // Увеличение массива на один элемент
            GrowArray(ref array);
            Console.WriteLine("\nArray increased by 1 element:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("\nNew Array Length is: {0}", array.Length);

            // Добавление элемента в начало массива и увеличение массива на 1 элемент со сдвигом остальных элементов вправо
            Console.WriteLine("\n\nEnter number to insert:");
            int number = int.Parse(Console.ReadLine());
            Insert(ref array, number);

            Console.WriteLine("\nArray after:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("\nNew Array Length is: {0}", array.Length);

            // Delay
            Console.ReadKey();
        }

        #region Добавление нового элемента в начало массива со сдвигом остальных элементов вперёд
        static void Insert(ref int[] array, int newElement)
        {
            int[] temp = new int[array.Length + 1];
            temp[0] = newElement;
            for (int i = 0; i < array.Length; i++)
            {
                temp[i + 1] = array[i];
            }
            array = temp;
        }
        #endregion

        #region Увеличение массива на 1 элемент (в конце)
        static void GrowArray(ref int[] array)
        {
            int[] temp = new int[array.Length + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                if (i < array.Length)
                {
                    temp[i] = array[i];
                }
                else
                {
                    temp[i] = 0;
                }
            }
            array = temp;
        }
        #endregion
    }
}
