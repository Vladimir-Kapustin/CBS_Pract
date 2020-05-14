using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;		//https://infourok.ru/sbornik-zadach-po-teme-massivi-2705799.html

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random();
			int element, previous, next;

			int[] array = new int[rand.Next(100)];
			Console.WriteLine("Массив имеет: {0} элементов", array.Length);

			for (int i = 0; i < array.Length; i++)
			{
				element = rand.Next(200);
				next = i - 1;

				if (i == 0 || element >= array[next])
				{
					array[i] = element;
				}
				else
				{
					if (element >= array[next])
					{

					}
				}

			}
		}
	}
}
