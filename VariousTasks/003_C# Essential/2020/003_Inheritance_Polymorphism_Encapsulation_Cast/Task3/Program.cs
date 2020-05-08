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
			Vehicle vehiclePlane = new Plane(50, 40, 2000000, 1500, DateTime.Parse("03/20/2000"), 265, 20);
			Vehicle vehicleCar = new Car(3,2,20000,250,DateTime.Parse("05/15/2015"));
			Vehicle vehicleShip	= new Ship(100,25,20000000,80,DateTime.Parse("09/01/1995"),1500,"Jamayka");

			vehiclePlane.ShowInformation();
			vehicleCar.ShowInformation();
			vehicleShip.ShowInformation();
		}
	}
}
