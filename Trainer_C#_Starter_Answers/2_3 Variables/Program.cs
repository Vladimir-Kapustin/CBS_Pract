using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте две переменных типа double с именами op1 и op2 и начальными значениями 4.6 и -34.72 соответственно. Затем создайте переменные sum, dif, mul и div типа double и присвойте им значения суммы, разницы, произведения и деления значений op1 и op2 соответственно. После этого выведите в консоль значения sum, dif, mul и div по очереди, каждое – с новой строки, в таком формате: 
//<операнд1> <знак операции> <операнд2> = <результат операции>. Используйте элементы форматирования.
namespace _2_3_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            double op1 = 4.6;
            double op2 = -34.72;

            double sum = op1 + op2;
            double dif = op1 - op2;
            double mul = op1 * op2;
            double div = op1 / op2;

            Console.WriteLine("{0}{1}{2}={3}", op1, '+', op2, sum);
            Console.WriteLine("{0}{1}{2}={3}", op1, '-', op2, dif);
            Console.WriteLine("{0}{1}{2}={3}", op1, '*', op2, mul);
            Console.WriteLine("{0}{1}{2}={3}", op1, '/', op2, div);
        }
    }
}
