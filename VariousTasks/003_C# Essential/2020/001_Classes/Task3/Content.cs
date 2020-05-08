using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Content
	{
		string contentText;

		public string ContentText
		{
			private get
			{
				if (contentText == null)
				{
					return "отсутствует содержание книги";
				}
				return contentText;
			}
			set { contentText = value; }
		}

		public void Show()
		{
			Console.BackgroundColor = ConsoleColor.Green;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(ContentText);
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Gray;
		}
	}
}
