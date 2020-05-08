using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Alternative
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House(new Street("Vandy Vasilevskoy"), 57);

            //House house2 = house1.Clone();
            House house2 = house1.DeepClone();

            Console.WriteLine("Дом 1, Улица: {0}, Номер: {1}", house1.Street.Name, house1.Number);
            Console.WriteLine("Дом 2, Улица: {0}, Номер: {1}", house2.Street.Name, house2.Number);

            Console.WriteLine(new string('-', 50));
            house1.Street.Name = "Vladimirskaya";

            Console.WriteLine("После изменения улицы:");
            Console.WriteLine("Дом 1, Улица: {0}, Номер: {1}", house1.Street.Name, house1.Number);
            Console.WriteLine("Дом 2, Улица: {0}, Номер: {1}", house2.Street.Name, house2.Number);

        }
    }
}
