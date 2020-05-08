using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                            //В классе Base создайте виртуальный индексатор с одним методом свойства get, который просто будет возвращать arr[i], а в классе Derived его переопределите таким образом, чтобы он возвращал сумму i-того элемента массива базового класса и i-того элемента массива производного.
namespace Less5_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Base inst1 = new Base();
            Console.WriteLine(inst1[2]);

            Base inst2 = new Derived();
            Console.WriteLine(inst2[2]);

            Console.ReadKey();
        }
    }

    class Base
    {
        private int[] arr = new int[] { 1, 2, 3, 4, 5 };
        
        public virtual int this [int i]
        {
            get 
            {
                return arr[i];
            }
        }
    }

    class Derived : Base
    {
        private int[] arr = new int[] { 6, 7, 8, 9, 10 };
        
        public override int this [int i]
        {
            get
            {
                return base[i] + arr[i];
            }
        }
    }
}
