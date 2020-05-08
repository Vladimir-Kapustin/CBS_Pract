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
			Book book = new Book("Dekameron", "Giovanni Boccacho", "Some-content-text");

			//book.Title = "Dekameron";
			//book.Author = "Giovanni Boccacho";
			//book.Content = "Some-content-text";

			book.Show();
		}
	}
}
