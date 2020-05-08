using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(30, 40, 35, 45);
            Block block2 = new Block(30, 40, 35, 45);

            Console.WriteLine("Первый блок:");
            Console.WriteLine(block1);
            Console.WriteLine("Второй блок:");
            Console.WriteLine(block2);

            Console.WriteLine("Равны ли блоки?: {0}", block1.Equals(block2));
        }
    }
}
