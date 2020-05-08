using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В теле метода Main() создайте двумерный массив array значений типа int размера 4х4 и с помощью вложенных циклов for со счетчиками i и j проинициализируйте его за следующим правилом:
//i-тый, j-тый элемент массива = i*j .
namespace _8_2_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = i * j;
                }
            }
        }
    }
}
