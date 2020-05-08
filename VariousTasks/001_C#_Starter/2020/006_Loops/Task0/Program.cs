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
			int width = 10, height = 12;

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					Console.Write(":-O");
				}
				Console.WriteLine("\n");
			}
		}
	}
}
