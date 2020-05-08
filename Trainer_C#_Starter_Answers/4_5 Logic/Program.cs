using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Переменной а присвоить выражение, которое сдвигает число 56 на один бит влево, а переменной b – число 13 на три бита вправо.
namespace _4_5_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 56 << 1;
            int b = 13 >> 3;
        }
    }
}
