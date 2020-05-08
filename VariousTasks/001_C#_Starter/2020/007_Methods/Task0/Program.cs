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
			double x = 3, y = 55.6, z = 5;
			Console.WriteLine(Calculate(x, y, z));
		}

		public static double Calculate(double operand1, double operand2, double operand3)
		{
			return (operand1 + operand2 + operand3) / 3;
		}
	}
}
