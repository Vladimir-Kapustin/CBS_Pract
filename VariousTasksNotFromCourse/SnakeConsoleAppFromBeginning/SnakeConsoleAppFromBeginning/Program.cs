using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeConsoleAppFromBeginning
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 6;
			int x = 4;
			char ch = 'x';

			Console.SetCursorPosition(a, x);
			Console.WriteLine(ch);
		}
	}
}
