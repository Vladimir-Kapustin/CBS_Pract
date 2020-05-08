using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Generic_User_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> cars = new CarCollection<Car>();   //коллекция на 10 машин

            cars.Add(new Car("BMW", 2000));
            cars.Add(new Car("WolksWagen", 2001));
            cars.Add(new Car("Toyota", 2010));
            cars.Add(new Car("Porsche", 2016));

            cars.Add(new Car("BMW", 2000));
            cars.Add(new Car("WolksWagen", 2001));
            cars.Add(new Car("Toyota", 2010));
            cars.Add(new Car("Porsche", 2016));
            cars.Add(new Car("BMW", 2000));
            cars.Add(new Car("WolksWagen", 2001));
            cars.Add(new Car("Toyota", 2010));
            cars.Add(new Car("Porsche", 2016));

            Console.WriteLine(cars[1].Name + " " + cars[1].Year);
            Console.WriteLine(cars[3].Name + " " + cars[3].Year);

            Console.WriteLine();
            cars.Clear(); Console.WriteLine("Очищено");

            if (cars[3] ==null)
            {
                Console.WriteLine(":((((((( Внатуре очищено....");
            }
            
            

            Console.ReadKey();
        }
    }
}
