using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Multitude_Array_Based
{
    class Program
    {
        static void Main(string[] args)
        {
            SetCustom set1 = new SetCustom();

            set1.Add("John");
            set1.Add("Mark");
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            Console.WriteLine(new string('-',60));

            Console.WriteLine("\nPrinting the list\n");
            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
