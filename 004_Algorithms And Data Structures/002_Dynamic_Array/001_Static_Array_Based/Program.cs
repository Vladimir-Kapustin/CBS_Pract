using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Static_Array_Based
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 10, 15, 20, 25 };

            ArrayList<int> dArr = new ArrayList<int>(array);
            dArr.Display();

            dArr.Add(77);
            dArr.Display();

            dArr.Insert(88, 3);
            dArr.Display();

            dArr.RemoveAt(2);
            dArr.Display();

            dArr.Remove(25);
            dArr.Display();

            Console.WriteLine("\nOld element of index 1: {0}", dArr[1]);
            Console.WriteLine("Adding new element 123 on index 1 instead of {0}", dArr[1]);
            dArr[1] = 123;
            dArr.Display();

            Console.WriteLine("\nIndex of element 20 is: {0}", dArr.IndexOf(20));

            Console.WriteLine("\nValue 555 belongs to array?: {0}", dArr.Contains(555));

        }
    }
}
