using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Converter
{
    class ProgramOld
    {
        static void OldMain(string[] args)  //--переименовать просто в Main, если что
        {
            ConverterOld converter = new ConverterOld(26.5, 29.70, 0.4);
          
            Console.WriteLine("{0} USD", converter.SumUsd = 400); 
          
            converter.ShowUahUsd();
          
            Console.ReadKey();
        }
    }
}
