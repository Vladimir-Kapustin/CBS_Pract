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

			for (int i = 0; i < array.Length; i++)					//комментирую, чтоб не читать потом долго код...
			{
				element = rand.Next(100);
				previous = i - 1;
				next = previous + 1;

				while (element < array[previous] && previous >= 0)	//находим позицию для текущего элемента, в которой все элементы на позицию выше и далее - больше элемента, а все элементы на позицию ниже и далее - меньше.
				{
					previous--;
				}

				for (int j = i; j > previous; j--)
				{
					array[j] = array[j - 1];
				}
				
				next = array[previous + 1];
				array[previous + 1] = temp;

				if (i > 0 || element >= array[previous])	// Если элемент равен предыдущему - ставим его на текущую позицию. Проверка if i > 0 - это, чтоб previous не посчитался на "-1", если мы только в начале находимся.
				{
					array[i] = element;
				}
				else
				{
					
				}
			}
		}
	}
}
