using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Car : Vehicle
	{
		public Car(int length, int width, int price, int speed, DateTime creationDate)
			: base(length, width, price, speed, creationDate) {}
	}
}
