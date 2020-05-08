using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В данном случае программа выполняется иррационально. Оптимизируйте ее.
namespace Less3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Derived(1, 2, 3);
        }
    }

    class Base
    {
        public int x;
        public int y;
        public Base(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Derived : Base
    {
        public int z;
        public Derived(int x, int y, int z)
            : base(x, y)
        {
            this.z = z;
        }
    }
}
