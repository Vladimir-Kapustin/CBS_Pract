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
			Printer printer = new DerivedDerivedPrinter();
			printer.Print("text");

			DerivedPrinter derivedPrinter = (DerivedPrinter)printer;
			derivedPrinter.Print("text");

			DerivedDerivedPrinter derivedDerivedPrinter = (DerivedDerivedPrinter)derivedPrinter;
			derivedDerivedPrinter.Print("text");

			DerivedDerivedPrinter derivedDerivedPrinter1 = (DerivedDerivedPrinter)printer;
			derivedDerivedPrinter1.Print("text");

			DerivedDerivedPrinter derivedDerived = new DerivedDerivedPrinter();
			derivedDerived.Print("text");

			DerivedPrinter derived = derivedDerived;
			derived.Print("text");

			Printer printer1 = derivedDerived;
			printer1.Print("text");

			Printer printer2 = derived;
			printer2.Print("text");

			DerivedPrinter derived1 = new DerivedPrinter();
			Printer printer3 = derived1;
			printer3.Print("text");

			Printer printer4 = new DerivedDerivedPrinter();
			Printer printer5 = new DerivedPrinter();

			printer4.Print("text");
			printer5.Print("text");

			DerivedPrinter derived2 = (DerivedPrinter)printer4;
			derived2.Print("text");

		}
	}
}
