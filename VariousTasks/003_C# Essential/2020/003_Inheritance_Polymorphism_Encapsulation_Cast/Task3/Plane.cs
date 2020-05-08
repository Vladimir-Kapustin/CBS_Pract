using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Plane : Vehicle
	{
		int passengers, height;

		public Plane(int length, int width, int price, int speed, DateTime creationDate, int passengers, int height)
			: base(length, width, price, speed, creationDate)
		{
			this.passengers = passengers;
			this.height = height;
		}
		
		public int Passengers
		{
			get { return passengers; }
		}

		public int Height
		{
			get { return height; }
		}

		public override void ShowInformation()
		{
			Console.WriteLine("Plane:");
			base.ShowInformation();
			Console.WriteLine("passengers: {0}\n" +
								"height: {1}\n",
								Passengers,
								Height);
		}
	}
}
