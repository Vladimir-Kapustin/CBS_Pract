using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Extension_Method
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
            Console.WriteLine(new string('-',30));

           // int[] array = new int[list.Count];
            //array = list.GetArray();    // полная запись - GetArray<int>(). Но этот аргумент типа <int> - можно опустить (как по документации).

            //array = MyStaticClass.GetArray<int>(list);    // вызов расширяющего метода как обычный вызов статического метода.

            foreach (var item in list.GetArray())    // полная запись - GetArray<int>(). Но этот аргумент типа <int> - можно опустить (как по документации).  
            {
                Console.WriteLine(item);
            }
        }
    }
}
