using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			// 5! = 5*4*3*2*1 = 120
			int number = 5;
			int factorial = number;

			do
			{
				number--;
				factorial *= number;
			} while (number > 1);

			Console.WriteLine(factorial);
		}
	}
}
