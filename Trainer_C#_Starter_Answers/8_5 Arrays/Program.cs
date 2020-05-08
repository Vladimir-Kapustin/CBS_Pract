using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В классе MyClass создайте функцию SumArguments(), которая будет принимать произвольное количество аргументов типа int и возвращать их сумму типа int.
namespace _8_5_Arrays
{
    class MyClass
    {
        int SumArguments(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
