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
			Console.WriteLine("Insert number");

			int number = Convert.ToInt32(Console.ReadLine());

			IsPositive(number);
			IsSimple(number);
			IsDivided(number);
		}

		public static void IsPositive(int number)
		{
			if (number > 0)
			{
				Console.WriteLine("the number is positive");
			}
			else if (number ==0)
			{
				Console.WriteLine("the number is equal to zero");
			}
			else
			{
				Console.WriteLine("the number is negative");
			}
		}

		public static void IsSimple(int number)
		{
			for (int i = 2; i < number; i++)
			{
				if (number%i==0)
				{
					Console.WriteLine("The number is NOT simple");
					return;
				}
			}
			Console.WriteLine("the number is simple");
		}

		public static void IsDivided(int number)
		{
			if (number%2==0)
			{
				Console.WriteLine("the number can be divided by 2");
			} 

			if (number % 3 == 0)
			{
				Console.WriteLine("the number can be divided by 3");
			} 

			if (number % 6 == 0)
			{
				Console.WriteLine("the number can be divided by 6");
			} 

			if (number % 9 == 0)
			{
				Console.WriteLine("the number can be divided by 9");
			}

			if (number % 2 != 0 && number % 3 != 0 && number % 6 != 0 && number % 9 != 0)
			{
				Console.WriteLine("the number can`t be divided by 2, 3, 6 or 9");
			}
		}
	}
}
