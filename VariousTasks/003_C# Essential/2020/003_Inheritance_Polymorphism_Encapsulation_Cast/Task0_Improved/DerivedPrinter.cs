using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0_Improved
{
	class DerivedPrinter : Printer
	{
		public DerivedPrinter (ConsoleColor color) : base (color)
		{
			//this.color = color;
		}
	}
}
