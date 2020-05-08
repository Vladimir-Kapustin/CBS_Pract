using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Найдите и исправьте ошибки в коде
namespace _7_3_Methods
{
    class Program
    {
        static void Greetings(out string s)
        {
            s = "Hello, everyone!";
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            string @string;
            Greetings(out @string);
            Console.ReadKey();
        }
    }
}
