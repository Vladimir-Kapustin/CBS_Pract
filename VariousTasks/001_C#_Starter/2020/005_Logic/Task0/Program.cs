using System;
using System.Collections.Generic;				//--The Power Of Two Check
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0
{
	class Program
	{
		static void Main(string[] args)
		{
			int number, result;

			while (true)
			{
				Console.WriteLine("Insert number");
				number = Convert.ToInt32(Console.ReadLine());

				result = number & (~number + 2);						//--мда... первый раз, когда делал - было гораздо лаконичнее, проще и элегантней, и, кажется затруднений не вызвало абсолютно. Я даже не помню, чтобы я вообще решение искал. Оно пришло сразу. осталось только программку саму вбить. Сейчас же... Если посчитать суммарность получасовок... 3 ил 4 сидел если не больше... А исписал сколько бумаги! Что за ЁПТ??? Я стал сравнивать, что, почему, как, сравнивать обстоятельства, вобщем натолкнуло меня на мысли, на размышления

				if (number == result)
				{
					Console.WriteLine("The number {0} is a power of two", number);
				}
				else
				{
					Console.WriteLine("The number {0} is NOT a power of two\n", number);
				}
			}
		}
	}
}
