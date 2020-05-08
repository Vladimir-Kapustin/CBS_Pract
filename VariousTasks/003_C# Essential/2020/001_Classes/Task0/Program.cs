using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0
{
	class Program
	{
		static void Main(string[] args)
		{
			Address address = new Address();

			address.Index = 61000;
			address.Country = "Ukraine";
			address.City = "Kharkov";
			address.Street = "Klochkovskaya";
			address.House = 154;
			address.Apartment = 156;

			Console.WriteLine("Full address is: \nIndex: {0}, \nCountry: {1}, \nCity: {2}, \nStreet: {3}, \nHouse: {4}, \nApartment: {5}", address.Index, address.Country, address.City, address.Street, address.House, address.Apartment);
		}
	}

	class Address
	{
		int index;
		string country;
		string city;
		string street;
		int house;
		int apartment;
		
		public int Index
		{
			get { return index; }
			set { index = value; }
		}

		public string Country
		{
			get { return country; }
			set { country = value; }
		}

		public string City
		{
			get { return city; }
			set { city = value; }
		}

		public string Street
		{
			get { return street; }
			set { street = value; }
		}
		public int House
		{
			get { return house; }
			set { house = value; }
		}

		public int Apartment
		{
			get { return apartment; }
			set { apartment = value; }
		}
	}
}
