using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                            //Создать массив размерностью N элементов, заполнить его произвольными целыми значениями. Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения. 
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определение числа элементов массива
            Console.WriteLine("Введите число элементов массива:");
            int quantity = Int32.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', 20));
            
            //рандомайзер и вспомогательные переменные
            Random random = new Random();
            int max = 0;
            int min = 1000;
            int sum = 0;

            //Инициализация, заполнение и вывод на экран 
            Console.WriteLine("Нечётные элементы:");
            int[] array = new int[quantity];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1000);

                if (array[i] % 2 != 0)                  //Вывод нечётных
                    Console.WriteLine(array[i]);

                if (array[i] > max)                     //Максимальное
                    max = array[i];

                if (array[i] < min)                     //Минимальное
                    min = array[i];

                sum += array[i];                        //Сумма
            }

            Console.WriteLine(new string('-', 20));

            //Вывод результатов на экран
            Console.WriteLine("Наибольшее число равно {0}", max);
            Console.WriteLine("Наименьшее число равно {0}", min);
            Console.WriteLine("Общая сумма элементов равна {0}", sum);
            Console.WriteLine("Среднее арифметическое равно {0}", sum/quantity);
        }
    }
}
