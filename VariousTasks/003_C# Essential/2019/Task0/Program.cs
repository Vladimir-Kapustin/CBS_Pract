using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                            //Расширьте пример 5 (русско-английский словарь) еще и украинским словарем. Реализуйте возможность поиска не только по ключевым русским словам и словам на остальных языках. 
namespace Task0
{
    class Program
    {
        static void Main()
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine(dictionary["apple"]);
            Console.WriteLine(dictionary["table"]);

            Console.WriteLine(dictionary["сонце"]);
            Console.WriteLine(dictionary["яблуко"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
