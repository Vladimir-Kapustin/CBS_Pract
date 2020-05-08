using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Generic_Dictionary_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("table", "стол");
            dict.Add("apple", "яблоко");
            dict.Add("sun", "солнце");

            Console.WriteLine(dict.ToString());
            Console.WriteLine("------------------");

            Console.WriteLine(dict[2]);
            Console.WriteLine("------------------");

            Console.WriteLine(dict.Count);
            Console.WriteLine("------------------");
        }
    }
}
