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
			#region Rectangle
			// Rectangle

			Console.WriteLine("Rectangle:");

			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 15; j++)
				{
					Console.Write("*");
					Console.Write(" ");
				}
				Console.Write("\n");
			}
			#endregion

			#region Right triangle
			// Right triangle

			Console.WriteLine("\nRight triangle:");

			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < i + 1; j++)
				{
					Console.Write("*");
					Console.Write(" ");
				}
				Console.Write("\n");
			}
			#endregion

			#region Right triangle - 2-nd variant
			// Right triangle - 2-nd variant

			Console.WriteLine("\nRight triangle - 2-nd variant:");

			int count = 10;
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < count; j++)
				{
					if (j < count - i)
					{
						Console.Write(" ");
					}

					if (j >= count - i)
					{
						Console.Write("*");
					}
				}
				Console.Write("\n");
			}
			#endregion

			#region Equilateral triangle
			// Equilateral triangle

			Console.WriteLine("\nEquilateral triangle:");

			for (int i = 0; i < 10; i++)
			{
				// Left half
				for (int j = 0; j <= count; j++)
				{
					if (j < count - i)
					{
						Console.Write(" ");
					}

					if (j >= count - i)
					{
						Console.Write("*");
					}
				}
				// Right half
				for (int j = 0; j < count; j++)
				{
					if (j < i)
					{
						Console.Write("*");
					}

					if (j >= i)
					{
						Console.Write(" ");
					}
				}
				Console.Write("\n");
			} 
			#endregion

			#region Rhombus
			// Rhombus

			Console.WriteLine("\nRhombus:");
			// Upper half
			for (int i = 0; i < 10; i++)
			{
				// Upper Left quarter
				for (int j = 0; j <= count; j++)
				{
					if (j < count - i)
					{
						Console.Write(" ");
					}

					if (j >= count - i)
					{
						Console.Write("*");
					}
				}
				// Upper Right quarter
				for (int j = 0; j < count; j++)
				{
					if (j < i)
					{
						Console.Write("*");
					}

					if (j >= i)
					{
						Console.Write(" ");
					}
				}
				Console.Write("\n");
			}

			// Lower half
			for (int i = 0; i <= 10; i++)
			{
				// Lower Left quarter
				for (int j = 0; j <= count; j++)
				{
					if (j < i)
					{
						Console.Write(" ");
					}

					if (j >= i)
					{
						Console.Write("*");
					}
				}
				// Lower Right quarter
				for (int j = 0; j <= count; j++)
				{
					if (j < count - i)
					{
						Console.Write("*");
					}

					if (j >= count - i)
					{
						Console.Write(" ");
					}
				}
				Console.Write("\n");
			} 
			#endregion

			#region Megafigura
			// Megafigura

			Console.WriteLine("\nMegafigura:");

			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < count; j++)
				{
					if (j < count - (i + 1))
					{
						Console.Write(" ");
					}

					if (j >= count - (i + 1))
					{
						Console.Write("*");
						for (int y = 0; y < count - i; y++)
						{
							Console.Write(" ");
						}
					}
				}
				Console.Write("\n");
			} 
			#endregion
		}
	}
}
