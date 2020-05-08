using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В класс MyMathClass поместите рекурсивную функцию Factorial() вычисления факториала натурального числа, которая будет принимать один аргумент типа int и будет возвращать результат типа int. Функция должна давать правильный результат и при нулевом аргументе (0! = 1)
namespace _7_5_Methods_Recursion
{
    class MyMathClass
    {
        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
