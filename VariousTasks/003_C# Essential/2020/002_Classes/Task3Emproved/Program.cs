using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Emproved
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee employee = new Employee("Peter", "Petrov");

			employee.Position = "Manager";
			employee.Experience = 10;	

			employee.Show();
		}
	}
}
