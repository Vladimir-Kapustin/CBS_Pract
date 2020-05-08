using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                    //Найдите и исправьте ошибки в коде
namespace Less1_Task4
{
    class Program
    {
        public static void Main()
        {
            MyClass myClass = new MyClass();

            Console.WriteLine(myClass.X);
        }
    }

    class MyClass
    {
        int x;

        public int X { get { return x; } }

        public MyClass()
        {

        }

        public MyClass(int x)
        {
            this.x = x;
        }
    }
}
