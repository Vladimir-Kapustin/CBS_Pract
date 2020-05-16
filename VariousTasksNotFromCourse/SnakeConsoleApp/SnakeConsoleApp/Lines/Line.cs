using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeConsoleApp.Lines
{
	public class Line
	{
		public void HorizontalLine(int left, int top, char symbol, int length)
		{
			for (int i = left; i < length; i++)
			{
				Console.SetCursorPosition(i,)
					Console.WriteLine(symbol);
			}
		}
	}
}
