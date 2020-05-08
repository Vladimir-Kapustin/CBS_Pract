using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Add_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.Add(1);
            list.Add(33);
            list.Add(42);
            list.Add(56);       //4     - (для проверки): числа, кратные 4
            list.Add(4);    //5         - числа, кратные 5
            list.Add(98);
            list.Add(3);
            list.Add(7);        //8
            list.Add(88);
            list.Add(2);    //10
            list.Add(56);
            list.Add(21);       //12
            list.Add(11);
            list.Add(5);
            list.Add(55);   //15
            list.Add(80);       //16
            list.Add(4);
            list.Add(75);
            list.Add(82);
            list.Add(34);   //20//20
            list.Add(17);
            list.Add(29);
            list.Add(35);
            list.Add(13);       //24
            list.Add(22);   //20


            list.Display();
            Console.WriteLine();

            list.RemoveFives();

            Console.WriteLine("\nNow elements is:");
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("\nNumber of elements is {0}", list.Count);


            Console.ReadKey();
        }
    }
}
