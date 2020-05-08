using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            int r = 5;
            double S = pi * (Math.Pow(r,2));    // Все арифметические операции производимые над двумя значениями типа (byte, sbyte, short, ushort) в качестве результата, возвращают значение типа int. 
                                                // Для типов int, uint, long и ulong, не происходит преобразования типа результата арифметических операций. Значит для double и т.д. - аналогично?
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
