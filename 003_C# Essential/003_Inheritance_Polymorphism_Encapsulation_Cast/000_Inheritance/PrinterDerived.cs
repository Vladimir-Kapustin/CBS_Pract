using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Inheritance
{
    class PrinterDerived : Printer
    {
        public PrinterDerived (ConsoleColor color)
            :base(color)
        {
            
        }
    }
}
