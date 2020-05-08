using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _000_ArrayList
{
    public struct NewStruct
    { }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            arr.Add(5);
            arr.Add(DateTime.Now);
            arr.Add(new object());
            arr.Add(ConsoleColor.Black);
            arr.Add("stroka");
            arr.Add((byte)66);
            arr.Add(false);

            Program prog = new Program();
            NewStruct myStruct = new NewStruct();

            arr.Add(prog);
            arr.Add(myStruct);
            arr.Add(new Program());
            arr.Add(new NewStruct());


            foreach (var i in arr)
            {
                Console.WriteLine("{0} - {1} - is ValueType: {2}", i, i.GetType(), (i is ValueType));
            }

            Console.WriteLine(new string('-',50));

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine("{0} - {1} - is ValueType: {2}", arr[i], arr[i].GetType(), (arr[i] is ValueType));
            }

            Console.ReadKey();
        }
    }
}
