using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less2_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1");
            MyClass inst = new MyClass();

            Console.Write("2");

            Console.ReadKey();
        }
    }

    class MyClass
    {
        MyClass field;

        public MyClass()
        {
            field = new MyClass();
        }
    }
}
/* Ответ:

1

*/