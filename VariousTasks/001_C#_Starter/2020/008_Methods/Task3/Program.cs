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
			Console.WriteLine("insert the number of cleints");
			int clients = Int32.Parse(Console.ReadLine());

			Console.WriteLine("the number of routs is {0}! (Factorial of {0}) and is: {1}", clients, CalculateRoutes(clients));

		}

		public static int CalculateRoutes(int clients)
		{
			if (clients==0)
			{
				return 1;
			}
			return clients * CalculateRoutes(--clients);
		}
	}
}
