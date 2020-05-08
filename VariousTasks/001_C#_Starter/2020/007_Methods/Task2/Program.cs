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
			while (true)
			{
				Console.WriteLine("insert 1 operand");
				int operand1 = Int32.Parse(Console.ReadLine());
				Console.WriteLine("insert 2 operand");
				int operand2 = Int32.Parse(Console.ReadLine());

				Console.WriteLine("choose operation (+,-,*,/)");
				string operation = Console.ReadLine();

				switch (operation)
				{
					case "+":
						Add(operand1, operand2);
						break;
					case "-":
						Sub(operand1, operand2);
						break;
					case "*":
						Mul(operand1, operand2);
						break;
					case "/":
						Div(operand1, operand2);
						break;
					default:
						Console.WriteLine("wrong operation!");
						break;
				}
			}
		}

		public static void Add(int operand1, int operand2)
		{
			Console.WriteLine("result is {0}", operand1 + operand2);
		}

		public static void Sub(int operand1, int operand2)
		{
			Console.WriteLine("result is {0}", operand1 - operand2);
		}

		public static void Mul(int operand1, int operand2)
		{
			Console.WriteLine("result is {0}", operand1 * operand2);
		}

		public static void Div(int operand1, int operand2)
		{
			if (operand2==0)
			{
				Console.WriteLine("Divide by zero!");
			}
			else
			{
				Console.WriteLine("result is {0}", operand1 / operand2);
			}
		}
	}
}
