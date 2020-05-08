using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Anonymous_Method
{
    public delegate int MyDelegate(int x, int y, int z);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = delegate(int x, int y, int z) { return (x + y + z) / 3; };
            int average = myDelegate(5, 10, 15);
            Console.WriteLine(average);

            Console.ReadKey();
        }
    }
}
