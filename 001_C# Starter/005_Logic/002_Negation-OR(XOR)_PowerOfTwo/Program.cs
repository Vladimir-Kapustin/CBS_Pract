using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Для чисел, которые являются степенью двойки, побитовое отрицание числа, затем побитовое 
            // OR (или XOR) результата с исходным числом всегда даёт -1;

            int operand1 = 84;                        // [0100 0000 Bin] = [64 Dec]   | or ^
            int operand2 = ~ operand1;                // [1011 1111 Bin] = [-65 Dec]
            int result = operand1 | operand2;         // [1111 1111 Bin] = [-1 Dec]

            // int result = operand1 ^ operand2;      // [1111 1111 Bin] = [-1 Dec]

            if (result == -1)
            {
                Console.WriteLine("The number is a power of two");
            }
            else if (result != -1)
            {
                Console.WriteLine("The number is not a power of two");
            }
            Console.ReadKey();
        }
    }
}
