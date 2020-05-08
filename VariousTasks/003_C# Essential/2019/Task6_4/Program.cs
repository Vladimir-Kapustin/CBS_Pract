using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            ArrayClass.Fill(array);

            Console.WriteLine(new string('-', 20) + "Массив до сортировки:" + new string('-', 20));
            ArrayClass.Show(array);
            array.Sort();   // Расширяющий метод

            Console.WriteLine(new string('-', 20) + "Массив после сортировки:" + new string('-', 20));
            ArrayClass.Show(array);
        }
    }

    static class ArrayClass
    {
        // Расширяющий метод
        public static void Sort(this int[] array)       // Bubble sort
        {
            int cycles = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < cycles; j++)
                {
                    Swap(array, j, (j + 1));
                }
                cycles --;
            }
        }

        static void Swap(int [] array, int left, int right)
        {
            if (array[left] > array[right])
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
        }


        public static void Fill(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 20);
            }
        }

        public static void Show(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
