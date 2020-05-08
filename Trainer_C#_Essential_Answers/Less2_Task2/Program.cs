using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        //Удалите лишний код, который противоречит логике работы ключевого слова readonly. Само это слово не трогать!
namespace Less2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass inst = new MyClass();
            Console.WriteLine(inst.Field);

            Console.WriteLine(inst.Field);

            Console.ReadKey();
        }

        class MyClass
        {
            readonly string field = "Field0";

            public string Field { get { return field; } }
            public MyClass()
            {
                field = "Field1";
            }
        }
    }
}
