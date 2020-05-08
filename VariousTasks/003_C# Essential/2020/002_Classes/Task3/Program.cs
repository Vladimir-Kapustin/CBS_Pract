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
			Employee employee = new Employee("Peter", "Petrov");

			employee.Salary("Manager", 10);	//вот этот мне метод не нравится и то как он взаимодействует с объектом. Добавить свойства. Не использовать какие-то методы для установки значений полей! Этим занимаются к-ры и свойства! Методы - для действий.


			employee.Show();
		}
	}
}
