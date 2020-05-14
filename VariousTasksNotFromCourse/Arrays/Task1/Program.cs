using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;		//https://infourok.ru/sbornik-zadach-po-teme-massivi-2705799.html

namespace Task1						//Задан упорядоченный по возрастанию целочисленный массив. Сформировать второй массив из случайных целых чисел, которые не встречаются в первом 
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random();
			int element, previous, next, temp;

			int[] array = new int[rand.Next(100)];
			Console.WriteLine("Массив имеет: {0} элементов", array.Length);

			for (int i = 0; i < array.Length; i++)
			{
				element = rand.Next(100);
				previous = i - 1;

				if (i == 0 || element >= array[previous])
				{
					array[i] = element;
				}
				else
				{
					while (element < array[previous] && previous >= 0)
					{
						previous--;
					}

					temp = array[previous];
					array[previous] = element;
					next = array[previous + 1];
					array[previous + 1] = temp;
				}
			}
		}
	}
}
