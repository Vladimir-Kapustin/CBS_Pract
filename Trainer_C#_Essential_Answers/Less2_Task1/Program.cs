using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        //Найдите и исправьте ошибки в коде
namespace Less2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 myClass = new Class1();
            myClass.Method();

            Console.ReadKey();
        }

        partial class Class1
        {
            partial void PartialMethod();
        }

        partial class Class1
        {
            partial void PartialMethod()
            {
                Console.WriteLine("partial method");
            }

            public void Method() { PartialMethod(); }
        }
    }
}
