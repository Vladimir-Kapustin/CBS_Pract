using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Возьмите содержимое метода Main() в безымянный блок и включите для этого блока проверку переполнения.
namespace _2_4_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                ushort s = 65535;
                s++;
                Console.WriteLine(s);
            }
        }
    }
}
