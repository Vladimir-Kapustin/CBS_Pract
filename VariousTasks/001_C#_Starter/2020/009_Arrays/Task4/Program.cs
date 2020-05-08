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
			int[] array;

			Console.WriteLine("insert the length of the array:");
			int arrayLength = Int32.Parse(Console.ReadLine());

			//create, fill and print array
			array = new int[arrayLength];

			Fill(ref array);

			Console.WriteLine("array is:");
			PrintArray(array);

			Console.WriteLine("\narray length is {0}", array.Length);

			//add one element print the array
			Console.WriteLine("insert the value you want to add to array");
			int value = Int32.Parse(Console.ReadLine());

			Add(ref array, value);

			Console.WriteLine("\nchanged array is:");
			PrintArray(array);
			Console.WriteLine("\narray length is {0}", array.Length);

		}

		public static void Add(ref int[] array, int value)
		{
			int [] tempArray = new int[array.Length+1];

			tempArray[0] = value;

			for (int i = 0; i < array.Length; i++)
			{
				tempArray[i + 1] = array[i];
			}
			array = tempArray;
		}

		// old methods from previous Task
		public static void Fill(ref int[] array)
		{
			Random rand = new Random();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rand.Next(100);
			}
		}

		public static void PrintArray(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
		}
	}
}
