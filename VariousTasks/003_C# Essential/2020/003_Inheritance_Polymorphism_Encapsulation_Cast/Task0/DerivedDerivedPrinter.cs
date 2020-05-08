using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0
{
	class DerivedDerivedPrinter : DerivedPrinter
	{
		public new void Print(string value)
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.WriteLine(value + " from DerivedDerivedPrinter");
			Console.BackgroundColor = ConsoleColor.Black;
		}
	}
}
