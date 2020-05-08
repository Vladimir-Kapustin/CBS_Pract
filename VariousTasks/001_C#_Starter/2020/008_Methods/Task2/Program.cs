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
			Console.WriteLine("insert the payment amount");
			int amount = Convert.ToInt32(Console.ReadLine());

			Payment(amount);
		}

		public static void Payment(int amount)
		{
			int outStanding = 1000;

			outStanding -= amount;

			if (outStanding<=0)
			{
				Console.WriteLine("the debd is fully paid");

				if (outStanding < 0)
				{
					Console.WriteLine("the sum of overpayment is {0}", outStanding*(-1));
				}
			}
			else
			{
				Console.WriteLine("the outstanding is {0}", outStanding);
			}
		}
	}
}
