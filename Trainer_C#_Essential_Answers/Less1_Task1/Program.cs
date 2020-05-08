using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        //В методе Main класса Program создать экземпляр класса MyClass с именем instance, присвоить его строковому полю field значение "myInstance" и вывести это значение на экран.
namespace Less1_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.field = "myInstance";
            Console.WriteLine(instance.field);
        }
    }

    class MyClass
    {
        public string field;
    }
}
