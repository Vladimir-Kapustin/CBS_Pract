using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			int A = 10, B = 55, sum = 0;

			// 1.
			for (int i = A + 1; i < B; i++)
			{
				sum += i;
			}
			Console.WriteLine("Sum of all between {0} and {1}", A, B);
			Console.WriteLine(sum);

			// 2.
			Console.WriteLine("All odds between {0} and {1}", A, B);
			for (int i = A+1; i < B; i++)
			{
				if (i%2!=0)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
