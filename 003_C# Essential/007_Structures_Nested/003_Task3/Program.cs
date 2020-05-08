using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Task3
{
    class Program
    {
        static void StruktTaker (MyStruct myStruct)
        {
            myStruct.Change = "изменено"; 
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.Change = "изменено";
        }
        static void Main(string[] args)
        {
            //MyStruct myStruct = new MyStruct("не изменено");
            MyStruct myStruct;
            myStruct.change = "не изменено";
            StruktTaker(myStruct);
            Console.WriteLine(myStruct.Change);
            
            MyClass myClass = new MyClass("не изменено");
            ClassTaker(myClass);
            Console.WriteLine(myClass.Change);

            Console.ReadKey();
        }
    }
}
