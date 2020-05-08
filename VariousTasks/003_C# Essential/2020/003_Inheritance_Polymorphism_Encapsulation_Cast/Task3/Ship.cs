using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Ship : Vehicle
	{
		int passengers;
		string port;

		public Ship(int length, int width, int price, int speed, DateTime creationDate, int passengers, string port)
			: base(length, width, price, speed, creationDate)
		{
			this.passengers = passengers;
			this.port = port;
		}

		public int Passengers
		{
			get { return passengers; }
		}

		public string Port
		{
			get { return port; }
		}
		
		public override void ShowInformation()
		{
			Console.WriteLine("Ship:");
			base.ShowInformation();
			Console.WriteLine("passengers: {0}\n" +
								"port: {1}\n",
								Passengers,
								Port);
		}
	}
}
