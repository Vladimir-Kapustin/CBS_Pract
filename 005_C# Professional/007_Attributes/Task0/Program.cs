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
			SecuredSection secured = new SecuredSection();
			Director director = new Director();
			Manager manager = new Manager();
			Programmer programmer = new Programmer();

			director.TryAccess(secured);
			manager.TryAccess(secured);
			programmer.TryAccess(secured);

		}
	}
}
