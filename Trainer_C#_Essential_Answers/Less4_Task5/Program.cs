using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                            //Найдите и исправьте ошибки в коде
namespace Less4_Task5
{
    interface Interface
    {
        void Method();
    }

    abstract class AbstractClass : Interface
    {
        public abstract void Method();
    }

    class ConcreteClass : AbstractClass
    {
        public override void Method()                           //--override надо добавить ;)
        {
            Console.WriteLine("Метод - реализация интерфейса в абстрактном классе.");
        }
    }

    class Program
    {
        static void Main()
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method();

            Console.ReadKey();
        }
    }
}
