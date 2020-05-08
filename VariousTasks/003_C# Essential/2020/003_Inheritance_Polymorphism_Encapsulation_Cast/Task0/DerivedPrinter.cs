using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0
{
	class DerivedPrinter : Printer
	{
		public new void Print(string value)
		{
			Console.BackgroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine(value + " from DerivedPrinter");
			Console.BackgroundColor = ConsoleColor.Black;
		}
	}
}
