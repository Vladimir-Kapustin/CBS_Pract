using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Generic_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert number of elements in dictionary");
            int number = int.Parse(Console.ReadLine());

            MyDictionary<string, string> dict = new MyDictionary<string, string>(number);

            string slovo;
            string perevod;
            int nomer;    
            for (int i = 0; i < dict.Length; i++)
            {
                Console.WriteLine("Insert word");
                slovo = Console.ReadLine();
                Console.WriteLine("...and translation");
                perevod = Console.ReadLine();
                Console.WriteLine("insert number in list");
                nomer = int.Parse(Console.ReadLine());
                dict.Add(nomer, slovo, perevod);
                Console.WriteLine("Thanks!");
                Console.WriteLine("another one? (yes/...anything...)");
                if (Console.ReadLine().ToLower()=="yes")
                {
                }
                else { break; }
            }

            Console.WriteLine("showing all");
            for (int i = 0; i < dict.Length; i++)
            {
                if (dict[i]!=null)
                {
                    Console.WriteLine(dict[i]);
                }
            }
            Console.WriteLine("А свойство Length - уже использовали в циклах. (ля-ля-ля!)");

            Console.ReadKey();
        }
    }
}
