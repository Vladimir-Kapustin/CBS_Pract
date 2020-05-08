using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        //Найдите и исправьте ошибки в коде (если они есть, конечно)
namespace Less4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassB instance = new ClassC();

            instance.MethA();
            instance.MethB();
            instance.MethC();

            Console.ReadKey();
        }
    }

    class ClassA
    {
        public void MethA()
        {
            Console.WriteLine("meth from ClassA");
        }
    }

    abstract class ClassB : ClassA
    {
        public void MethB()
        {
            Console.WriteLine("meth from ClassB");
        }
        public abstract void MethC();
    }

    class ClassC : ClassB
    {
        public override void MethC()
        {
            Console.WriteLine("meth from ClassC");
        }
    }
}
