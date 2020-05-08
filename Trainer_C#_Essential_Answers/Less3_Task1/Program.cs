using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        //После объявления класса Base создать такой класс Derived, унаследованный от Base, чтобы его field1 по умолчанию имело значение “derived.f1”, а field2 – значение "base.f2".
namespace Less3_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived inst = new Derived();
            Console.WriteLine("f1 = {0}\tf2 = {1}", inst.field1, inst.field2);

            Console.ReadKey();
        }
    }

    class Base
    {
        public string field1 = "base.f1";
        public string field2 = "base.f2";
    }

    class Derived : Base
    {
        public string field1 = "derived.f1";
    }
}
