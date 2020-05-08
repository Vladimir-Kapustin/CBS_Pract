using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;

            Console.WriteLine("A | B = {0}", A | B);
            Console.WriteLine("!( !A & !B) = {0}", !(!A & !B));

            Console.ReadKey();
        }
    }
}
