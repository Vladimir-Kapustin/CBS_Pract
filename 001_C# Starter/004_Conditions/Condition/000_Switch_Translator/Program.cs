using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Переводчик слов о погоде---");
            Console.WriteLine("Введите слово на русском языке");

            string russian = Console.ReadLine().ToLower();

            switch (russian)
            {
                case "солнечно":
                    Console.WriteLine("Sunny");
                    break;
                case "пасмурно":
                    Console.WriteLine("Mainly cloudy");
                    break;
                case "дождь":
                    Console.WriteLine("Rain");
                    break;
                case "ветренно":
                    Console.WriteLine("Giddily");
                    break;
                case "гололёд":
                    Console.WriteLine("Black ice");
                    break;
                case "снег":
                    Console.WriteLine("Snow");
                    break;
                case "потепление":
                    Console.WriteLine("Thaw");
                    break;
                case "похолодание":
                    Console.WriteLine("Cooling");
                    break;
                case "туманно":
                    Console.WriteLine("Foggy");
                    break;
                case "град":
                    Console.WriteLine("Hail");
                    break;
                default:
                    Console.WriteLine("Такого слова нет в словаре. Попробуйте ещё раз.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
