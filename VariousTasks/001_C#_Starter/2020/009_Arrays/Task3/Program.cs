using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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

			//create and print reversed array
			int[] reversedArray = MyReverse(array);
			Console.WriteLine("\nreversed array is:");
			PrintArray(reversedArray);

			//create and print subarray
			Console.WriteLine("\nstarting from which position of the reversed array you whant to create a subArray?");
			int index = Int32.Parse(Console.ReadLine());

			Console.WriteLine("insert how many elements must be in the new subArray?");
			int count = Int32.Parse(Console.ReadLine());

			int[] subArray = SubArray(reversedArray, index, count);

			Console.WriteLine("the new subarray is:");
			PrintArray(subArray);

			Console.WriteLine("\n" + array.GetHashCode());
			Console.WriteLine(reversedArray.GetHashCode());
		}

		public static int[] MyReverse(int[] array)
		{
			int count = array.Length;
			int[] someArr = new int[count];

			for (int i = 0; i < someArr.Length; i++)
			{
				someArr[i] = array[--count];
			}
			return someArr;
		}

		public static int[] SubArray(int[] array, int index, int count)
		{
			int[] someArray = new int[count];

			for (int i = 0; i < someArray.Length; i++)
			{
				if (index < array.Length)
				{
					someArray[i] = array[index++];
				}
				else
				{
					someArray[i] = 1;
				}
			}
			return someArray;
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
