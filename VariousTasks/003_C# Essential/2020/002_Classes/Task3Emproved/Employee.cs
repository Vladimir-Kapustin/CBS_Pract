using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Emproved
{
	class Employee
	{
		string name, surName, position;
		int experience;
		double salary, tax;

		public Employee(string name, string surName)
		{
			this.name = name;
			this.surName = surName;
		}

		void CalculateSalary(string Position, int Experience)
		{
			this.Position = position;
			switch (position)
			{
				case "President":
					salary = 1000;
					break;
				case "Manager":
					salary = 500;
					break;
				case "Specialist":
					salary = 250;
					break;
				default:
					Console.WriteLine("There`s no such position, insert right position");
					salary = 0;
					break;
			}

			Console.WriteLine(
			"\nSalary: {0}" + 
			"\nTax: {1}",
			salary += experience * 10,
			salary * .25);
		}

		public string Position
		{
			private get { return position; }
			set { position = value; }
		}

		public int Experience
		{
			private get { return experience; }
			set { experience = value; }
		}

		public void Show()
		{
			Console.WriteLine("Employee`s Name: {0}" +
								"\nSurname: {1}" +
								"\nPosition: {2}",
								name,
								surName,
								Position);

			CalculateSalary(Position, Experience);
		}
	}
}
