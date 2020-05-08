using System;                       // (Эта задача является вторым домашним (а не первым дополнительным) заданием в новейшем варианте
using System.Collections.Generic;   // материалов (Александра Шевчука))
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Первый способ.
            //      a) Побитовое AND чётного числа с единицей всегда даёт 0;
            //      b) Побитовое AND нечётного числа с единицей всегда даёт 1;
            
            // a)
            int operand1 = 86;                        // [0101 0110 Bin] = [86 Dec]   &
            int operand2 = 1;                         // [0000 0001 Bin] = [1 Dec]
            int result = operand1 & operand2;         // [0000 0000 Bin] = [0 Dec]

            // b)
            // int operand1 = 121;                    // [0111 1001 Bin] = [121 Dec]  &
            // int operand2 = 1;                      // [0000 0001 Bin] = [1 Dec]
            // int result = operand1 & operand2;      // [0000 0001 Bin] = [1 Dec]

            if (result==0)
            {
                Console.WriteLine("The number is even");
            }
            else if (result==1)
            {
                Console.WriteLine("The number is odd");
            }


            // 2) Второй способ.
            //      a) Побитовое OR чётного числа с единицей всегда даёт число, не равное ему (и всегда на 1 больше);
            //      b) Побитовое OR нечётного числа с единицей всегда даёт то же число;

            // a)
            int operand3 = 86;                         // [0101 0110 Bin] = [86 Dec]   |
            int operand4 = 1;                          // [0000 0001 Bin] = [1 Dec]
            int result2 = operand3 | operand4;         // [0101 0111 Bin] = [87 Dec]

            // b)
            // int operand3 = 121;                     // [0111 1001 Bin] = [121 Dec]  |
            // int operand4 = 1;                       // [0000 0001 Bin] = [1 Dec]
            // int result2 = operand3 | operand4;      // [0111 1001 Bin] = [121 Dec]

            if (result2 != operand3)
            {
                Console.WriteLine("The number is even");
            }
            else if (result2 == operand3)
            {
                Console.WriteLine("The number is odd");
            }
            Console.ReadKey();
        }
    }
}
