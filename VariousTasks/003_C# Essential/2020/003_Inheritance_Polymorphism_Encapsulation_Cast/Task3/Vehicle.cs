using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Vehicle
	{
		int length, width, price, speed;
		DateTime creationDate;

		public Vehicle(int length, int width, int price, int speed, DateTime creationDate)
		{
			this.length = length;
			this.width = width;
			this.price = price;
			this.speed = speed;
			this.creationDate = creationDate;
		}

		public int Length
		{
			get { return length; }
		}

		public int Width
		{
			get { return width; }
		}

		public int Price
		{
			get { return price; }
		}

		public int Speed
		{
			get { return speed; }
		}

		public DateTime CreationDate
		{
			get { return creationDate; }
		}

		public virtual void ShowInformation()
		{
			if ((this.GetType()!=typeof(Plane))&&(this.GetType()!=typeof(Ship)))
			{
				Console.WriteLine("Car:");
				Console.WriteLine("length: {0}\n" +
							"width: {1}\n" +
							"price: {2}\n" +
							"speed: {3}\n" +
							"creation date: {4}\n",
							Length,
							Width,
							Price,
							Speed,
							CreationDate.ToString());
			}
			else
			{
				Console.Write("length: {0}\n" +
							"width: {1}\n" +
							"price: {2}\n" +
							"speed: {3}\n" +
							"creation date: {4}\n",
							Length,
							Width,
							Price,
							Speed,
							CreationDate.ToString());
			}
		}
	}
}
