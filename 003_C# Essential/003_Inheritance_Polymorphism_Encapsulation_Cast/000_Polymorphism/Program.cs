using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Print from Base Class Printer");

            DerivedPrinter derivedPrinter = new DerivedPrinter();
            derivedPrinter.Print("Print from DerivedPrinter Class");

            Printer upCastedPrinter = derivedPrinter;
            upCastedPrinter.Print("Print from Base Link but from derived class and override Method");

            Console.ReadKey();
        }
    }
}
