using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_GenericClassMethod
{
    //public class MyClass<T>             // Этот код писал до того, как узнал конструкцию "where T : new()" - поскольку в видео её НЕТ!!!
    //                                    /*where T : new() - ограничение параметра типа Т, 
    //                                     * означает что в качестве типа Т можно поставить 
    //                                     * только тот тип у которого есть открытый конструктор 
    //                                     * по умолчанию */
    //{
    //    static T field;

    //    public MyClass(T argument)
    //    {
    //        field = argument;
    //    }

    //    public static T FactoryMethod()
    //    {
    //        return field;
    //    }
    //}

    //public class SomeClass
    //{
    //}

    //class Program1
    //{
    //    static void Main(string[] args)
    //    {
    //        SomeClass var1 = new SomeClass();
    //        MyClass<SomeClass> my = new MyClass<SomeClass>(var1);

    //        SomeClass var2 = MyClass<SomeClass>.FactoryMethod();

    //        Console.WriteLine(var2.GetType());

    //        Console.ReadKey();
    //    }
    //}
}
