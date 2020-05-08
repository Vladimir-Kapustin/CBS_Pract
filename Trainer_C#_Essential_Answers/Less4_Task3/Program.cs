using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        //Одноименные методы в интерфейсах. В классе MyClass напишите три реализации метода Method: сначала – явную реализацию из интерфейса IInterface1, затем - явную реализацию из интерфейса IInterface2, и в конце – собственную реализацию класса MyClass. Тела всех этих методов оставьте пустыми.
namespace Less4_Task3
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    interface IInterface1
    {
        void Method();
    }

    interface IInterface2
    {
        void Method();
    }

    class MyClass : IInterface1, IInterface2
    {
        void IInterface1.Method()
        {

        }
        void IInterface2.Method()
        {

        }
        public void Method()
        {

        }
    }
}
