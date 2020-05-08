using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dict = new MyDictionary<string, string>();

            dict.Add("sun", "солнце");
            dict.Add("table", "стол");
            dict.Add("orange", "апельсин");
            dict.Add("car", "машина");

            Console.WriteLine(new string ('-', 20));

            Console.WriteLine(dict[2]);

            Console.WriteLine(new string('-', 20));

            Console.WriteLine(dict["table"]);

            Console.WriteLine(new string('-', 20));

            foreach (string item in dict)
            {
                Console.WriteLine(item);
            }
        }
    }
}
