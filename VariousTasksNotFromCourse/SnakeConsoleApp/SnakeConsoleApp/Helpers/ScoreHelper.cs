using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeConsoleApp.Helpers
{
	public class ScoreHelper
	{
		public static void GetScore(int score)
		{
			Console.SetCursorPosition(2, 22);
			Console.WriteLine("Score: {0}", score); //в видео использована интерполяция $"Score: {score}" - из более поздних версий дотнет. я так понимаю
		}
	}
}
