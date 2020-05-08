using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			for (int i = array.Length - 1; i >= 0; i--)
			{
				Console.WriteLine(array[i]);
			}
			
			Console.WriteLine();

			int counter = array.Length - 1;
			for (int i = 0; i <= array.Length-1; i++)
			{
				Console.WriteLine(array[counter]);
				counter--;
			}
		}
	}
}
