using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeConsoleApp.Enums;
using System.Threading;
using SnakeConsoleApp.Lines;
using SnakeConsoleApp.Helpers;
using SnakeConsoleApp.Factory;
using SnakeConsoleApp.UI;

namespace SnakeConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			UIService uiService = new UIService();
			uiService.GetMenu();

			while (true)
			{
				ConsoleKeyInfo key = Console.ReadKey();
				uiService.GetCommand(key.Key);
			}
		}
	}
}
