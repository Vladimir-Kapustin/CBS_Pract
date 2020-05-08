using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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

		public void Salary(string position, int experience)
		{
			this.position = position;
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

			salary += experience * 10;

			tax = salary * .25;
		}

		public void Show()
		{
			Console.WriteLine("Employee`s Name: {0}" +
								"\nSurname: {1}" +
								"\nPosition: {2}" +
								"\nSalary: {3}" + 
								"\nTax: {4}",
								name,
								surName,
								position,
								salary,
								tax);
		}
	}
}
