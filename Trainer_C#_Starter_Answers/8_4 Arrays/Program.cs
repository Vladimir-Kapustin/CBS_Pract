using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В класс MyClass поместите функцию int[] PairValuesArray(int n), которая будет возвращать массив упорядоченных по возрастанию ЧЁТНЫХ натуральных чисел в промежутке от 0 (включительно!) до n включительно. Разрешается использовать только классы непосредственно из пространства имен System, все вложенные в него пространства имен использовать запрещается.
namespace _8_4_Arrays
{
    class MyClass
    {
        int[] PairValuesArray(int n)
        {
            int[] array = new int[n / 2 + 1];
            int counter = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    array[counter] = i;
                    counter++;
                }
            }

            return array;
        }
    }
}
