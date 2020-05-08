using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В тело класса MyMathClass поместите метод ulong power(uint x, uint n), который с помощью любого цикла и приращения результата в цикле будет вычислять результат возведения x в степень n. При этом метод должен корректно возводить число в нулевую степень (то есть возвращать 1).
namespace _7_5_Methods
{
    class MyMathClass
    {
        ulong power(uint x, uint n)
        {
            ulong temp = x;
            if (n == 0)
            {
                return 1;
            }
            else
            {
                while (n > 1)
                {
                    temp *= x;
                    n--;
                }
            }
            return temp;
        }
    }
}
