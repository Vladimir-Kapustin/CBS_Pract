using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_FormattingStringValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "\nмоя строка 1";     // Выводы: \n - переносит строку;
            string b = "\tмоя строка 2";     // \t - делает отступ;
            string c = "\aмоя строка 3";     // \a - выдаёт звуковой сигнал.

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
