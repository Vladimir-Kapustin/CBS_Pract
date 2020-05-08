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
			User user = new User("Vladimir", "Vladimir", "Kapustin", 41, "03/02/2020");

			user.Show();
		}
	}

	class User
	{
		string login, name, surname;
		int age;
		readonly DateTime fillDate;

		public User(string login, string name, string surname, int age, string fillDate)
		{
			this.login = login;
			this.name = name;
			this.surname = surname;
			this.age = age;
			this.fillDate = DateTime.Parse(fillDate);
		}

		public void Show()
		{
			Console.WriteLine("Данные пользователя: \n"+
								"Login: {0}\n" +
								"Name: {1}\n" +
								"Surname: {2}\n" +
								"Age: {3}\n" +
								"Data filling Date: {4}\n",
								login,name,surname,
								age,
								fillDate);
		}
	}
}
