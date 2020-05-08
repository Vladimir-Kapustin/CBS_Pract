using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В теле метода Main() создайте зубчатый массив с именем jagged, который будет состоять из трех массивов элементов типа int: первый – с элементами 1, 4, 7; второй – с элементами 2 и 6; третий – с единственным элементом 5.
namespace _8_3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new[]
            {
            new int [] {1,4,7},
            new int [] {2,6},
            new int [] {5}
            };
        }
    }
}
