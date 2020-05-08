using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        //Допишите код в соответствии с инструкциями. Заставьте корректно выполниться все методы, которые вызываются в Main, реализовав их следующим образом: Meth1 при приведении к любому из интерфейсов должен выводить на экран строку "method 1", а Meth2 – выводить на экран  "method 2".
namespace Less4_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            ((IInter1)instance).Meth1();
            ((IInter2)instance).Meth1();
            ((IInter2)instance).Meth2();

            Console.ReadKey();
        }
    }

    interface IInter1
    {
        void Meth1();
    }

    interface IInter2 : IInter1
    {
        void Meth2();
    }

    class MyClass : IInter2
    {
        void IInter1.Meth1()
        {
            Console.WriteLine("method 1");
        }
        void IInter2.Meth2()
        {
            Console.WriteLine("method 2");
        }
    }
}
