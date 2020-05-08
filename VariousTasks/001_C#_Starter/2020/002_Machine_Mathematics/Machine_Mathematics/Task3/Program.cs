using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c;
            a = "\n моя строка1";   //перенос строки
            b = "\t моя строка2";   //табулятор
            c = "\a моя строка3";   //звук

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
