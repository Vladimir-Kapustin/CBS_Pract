using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0_Improved
{
	class Printer
	{
		protected ConsoleColor color;

		public Printer(ConsoleColor color)
		{
			this.color = color;
		}
		
		public void Print(string value)
		{
			Console.BackgroundColor = color;
			Console.WriteLine(value);
			Console.BackgroundColor = ConsoleColor.Black;
		}
	}
}
