using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_GenericClassMethod
{
    public class MyClass<T> where T : new()            /*where T : new() - ограничение параметра типа Т, 
                                                        * означает что в качестве типа Т можно поставить 
                                                        * только тот тип у которого есть открытый конструктор 
                                                        * по умолчанию */
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }

    class SomeClass
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = MyClass<int>.FactoryMethod();
            Console.WriteLine(i.GetType());

            SomeClass s = MyClass<SomeClass>.FactoryMethod();
            Console.WriteLine(s.GetType());

            Program p = MyClass<Program>.FactoryMethod();
            Console.WriteLine(p.GetType());

            Console.ReadKey();
        }
    }
}
