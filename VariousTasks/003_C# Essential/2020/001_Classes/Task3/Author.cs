using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Author
	{
		string name;

		public string Name
		{
			private get
			{
				if (name == null)
				{
					return "отсутствует имя автора";
				}
				return name;
			}
			set { name = value; }
		}

		public void Show()
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine(Name);
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Gray;
		}
	}
}
