using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Title
	{
		string titleContent;

		public string TitleContent
		{
			private get 
			{
				if (titleContent == null)
				{
					return "отсутствует название"; 
				}
				return titleContent; 
			}
			set { titleContent = value; }
		}

		public void Show()
		{
			Console.BackgroundColor = ConsoleColor.Gray;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(TitleContent);
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Gray;
		}
	}
}
