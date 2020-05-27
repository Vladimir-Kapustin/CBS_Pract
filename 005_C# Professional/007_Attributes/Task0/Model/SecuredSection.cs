using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0
{
	class SecuredSection
	{
		public void Access(string level)
		{
			if (level == "Highest")
			{
				Console.WriteLine("Hello, you are Director, you have the highest access level");
			}
			else if (level =="Middle")
			{
				Console.WriteLine("Hello, you have middle level. Access limited");
			}
			else if (level == "Lowest")
			{
				Console.WriteLine("Hello, you have lowest level. Access denied");
			}
			else
			{
				Console.WriteLine("The level is undefined");
			}
		}
	}
}
