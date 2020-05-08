using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                            //чуть более правильное решение
namespace _000_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer basePrinter = new Printer(ConsoleColor.Gray);
            basePrinter.Print("asdf from base");

            PrinterDerived derivedPrinter = new PrinterDerived(ConsoleColor.Red);
            derivedPrinter.Print("asdf from derived");

            basePrinter = derivedPrinter;
            basePrinter.Print("asdf derived casted to base");

            Console.ReadKey();
        }
    }
}
