using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _002_IEnumerable_IEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            list.Add(2);
            list.Add(10);
            list.Add(11);
            list.Add(35);
            list.Add(64);
            list.Add(48);
            list.Add(55);
            list.Add(77);


            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
