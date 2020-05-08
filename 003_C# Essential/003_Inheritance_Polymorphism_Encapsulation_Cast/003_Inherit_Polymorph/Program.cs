using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Inherit_Polymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(20, 80, 7000000, 1000, 2001);
            Car car = new Car(35000, 350, 2005);
            Ship ship = new Ship(2500, "Yalta", 10000000, 50, 1999);

            plane.Show();
            car.Show();
            ship.Show();

            Console.ReadKey();
        }
    }
}
