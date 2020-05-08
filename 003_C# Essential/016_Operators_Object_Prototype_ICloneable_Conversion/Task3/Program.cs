using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House(42, "Saksaganskogo");
            House house2 = house1.Clone();

            Console.WriteLine("Дом №1:");
            house1.PrindInfo();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Поверхностное копирование");
            Console.WriteLine("Дом№2:");
            house1.PrindInfo();

            house1.Street = new Street("Dneprovskaya Naberezhnaya");

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("После изменения названия улицы");
            Console.WriteLine("Дом №1:");
            house1.PrindInfo();
            Console.WriteLine("Дом№2:");
            house1.PrindInfo();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Глубокое копирование");
            House house3 = house1.DeepClone();
            house3.Street = new Street("Druzhby Narodov");
            Console.WriteLine("После изменения названия улицы");
            Console.WriteLine("Дом №1:");
            house1.PrindInfo();
            Console.WriteLine("Дом №3:");
            house3.PrindInfo();
        }
    }
}
