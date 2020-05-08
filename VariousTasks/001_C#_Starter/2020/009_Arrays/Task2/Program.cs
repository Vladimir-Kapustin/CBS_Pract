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
			int[] array;

			Console.WriteLine("insert the length of the array:");
			int arrayLength = Int32.Parse(Console.ReadLine());

			array = new int[arrayLength];

			//fill array
			Fill(ref array);

			//print all array
			Console.WriteLine("array is:");
			PrintArray(array);

			Console.WriteLine("\nthe maximum element of the array is: {0}", CalculateMaximum(array));

			Console.WriteLine("the minimum element of the array is: {0}", CalculateMinimum(array));

			int sum = CalculateSum(array);
			Console.WriteLine("the sum of all elements of the array is: {0}", sum);

			Console.WriteLine("the average of all elements of the array is: {0}", sum/array.Length);

			//show all odds
			Console.WriteLine("the odds are:");
			PrintOdds(array);
		}
		/// <summary>
		/// Fills the array
		/// </summary>
		/// <param name="array">array of integers</param>
		public static void Fill(ref int[] array)
		{
			Random rand = new Random();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rand.Next(100);
			}
		}
		/// <summary>
		/// Prints the array
		/// </summary>
		/// <param name="array">array of integers</param>
		public static void PrintArray(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i]+" ");
			}
		}
		/// <summary>
		/// Searches maximum element
		/// </summary>
		/// <param name="array">array of integers</param>
		/// <returns>maxumum element of the array</returns>
		public static int CalculateMaximum(int[] array)
		{
			int max = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] > max)
					max = array[i];
			}
			return max;
		}

		public static int CalculateMinimum(int[] array)
		{
			int min = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] < min)
					min = array[i];
			}
			return min;
		}

		public static int CalculateSum(int[] array)
		{
			int sum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				sum += array[i];
			}
			return sum;
		}

		public static void PrintOdds(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i]%2>0)
				{
					Console.Write(array[i]+ " ");
				}
			}
		}
	}
}
