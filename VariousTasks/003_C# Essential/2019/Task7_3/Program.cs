using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_3
{
    public class MyClass
    {
        public string change;
    }

    public struct MyStruct
    {
        public string change;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            MyStruct ms = new MyStruct();

            mc.change = "не изменено";
            ms.change = "не изменено";

            ClassTaker(mc);
            StructTaker(ms);

            Console.WriteLine(mc.change);
            Console.WriteLine(ms.change);
        }

        public static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        public static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
}
