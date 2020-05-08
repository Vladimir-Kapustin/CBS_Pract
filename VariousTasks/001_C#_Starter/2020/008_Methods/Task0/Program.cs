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
			Console.WriteLine("insert number1");
			double operand1 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("insert number2");
			double operand2 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("insert number3");
			double operand3 = Convert.ToDouble(Console.ReadLine());

			Calculate(ref operand1, ref operand2, ref operand3);

			Console.WriteLine("the number1 divided by 5 is {0}", operand1);
			Console.WriteLine("the number2 divided by 5 is {0}", operand2);
			Console.WriteLine("the number3 divided by 5 is {0}", operand3);

		}

		public static void Calculate(ref double operand1, ref double operand2, ref double operand3)
		{
			operand1 /= 5;
			operand2 /= 5;
			operand3 /= 5;
		}
	}
}
