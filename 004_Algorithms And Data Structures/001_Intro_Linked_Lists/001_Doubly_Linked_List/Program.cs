using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Doubly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.Add(1);
            list.Add(33);
            list.Add(42);
            list.Add(56);  
            list.Add(4);   
            list.Add(98);
            list.Add(3);
            list.Add(7);   
            list.Add(88);
            list.Add(2);

            Console.WriteLine("Before:");
            list.Display();
            Console.WriteLine();

            int[] array = new int[3] { 123, 123, 123 };

            list.AddAfter(array, 3);

            Console.WriteLine("\nAfter:");
            list.Display();
            Console.WriteLine();

            Console.WriteLine("\nAdding to begining of the list");

            list.AddFirst(111);
            list.Display();

            Console.WriteLine("\nAdding to the end of the list");

            list.AddLast(999);
            list.Display();

            Console.WriteLine("\nClearing the list");

            list.Remove();
            list.Display();

            //Delay
            Console.ReadKey();
        }
    }
}
