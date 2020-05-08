using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Readonly
{
    class User
    {
        //Fields & Properties
     
        readonly DateTime date;

        public string Login { get; set;}

        public string Name { get; set;}

        public string LastName { get; set;}

        public int Age { get; set;}

        //Ctors
        public User(string login, string name, string lastName, int age)
        {
            Login = login;
            Name = name;
            LastName = lastName;
            Age = age;
            date = DateTime.Today;
        }

        public User() {  }

        //Print
        public void Show()
        {
            Console.WriteLine("Login - {0}", Login);
            Console.WriteLine("Name - {0}", Name);
            Console.WriteLine("Lastname - {0}", LastName);
            Console.WriteLine("Age - {0}", Age);
            Console.WriteLine("Date - {0}", date);
        }
    }
}
