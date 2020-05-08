using System;                           // (Эта задача является первым дополнительным (а не вторым домашним) заданием в новейшем варианте
using System.Collections.Generic;       // материалов (Александра Шевчука))
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Если к операнду и операнду, уменьшенному на единицу применить операцию & (побитовое И) и получится 0 то это
            // число является степенью двойки, т.е. если x & (x-1) == 0, то  х - является степенью двойки.
            // причём х не должен равняться 0, а то даст тоже 0. Поскольку ноль не является степенью двойки,
            // исключить его из расчёта, сделав соответствующую проверку на неравенство 0.
            
            int operand1 = 14;

            if ((operand1 != 0) && ((operand1 & (operand1 - 1)) == 0))          // [0100 0000 Bin] = [64 Dec]   &
            {                                                                   // [0011 1111 Bin] = [63 Dec]
                Console.WriteLine("The number is a power of two");              // [0000 0000 Bin] = [0 Dec]
            }
            else
            {
                Console.WriteLine("The number is not a power of two");
            }
            Console.ReadKey();
        }
    }
}
