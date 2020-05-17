using SnakeConsoleApp.Enums;
using SnakeConsoleApp.Factory;
using SnakeConsoleApp.Helpers;
using SnakeConsoleApp.Lines;
using SnakeConsoleApp.UserServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeConsoleApp
{
	class GamePlay
	{
		UserService _userService = 

		public void StartGame(User user) 
		{
			
			
			if (user==null)
			{
				user = new User();
			}
		
		//Point point = new Point(5, 5, 'x');
			//point.DrawPoint();

			Line line = new Line();
			line.HorizontalLine(0,0,'-', 120);
			line.HorizontalLine(0, 20, '-', 120);


			LineInstaller line = new LineInstaller();
			line.DrawShapes();

			Point food = FoodFactory.GetRandomFood(119, 20, "+");
			Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1,5));
			food.DrawPoint();
			Console.ResetColor();

			Snake snake = new Snake();
			snake.CreateSnake (5, new Point(5,5,"z"), DirectionEnum.Right);
			snake.DrawLine();

			ScoreHelper.GetScore(score);

			while (true)
			{
				if (snake.Eat(food))
				{
					score++;

					food = FoodFactory.GetRandomFood(119, 20, "+");
					Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
					food.DrawPoint();
					Console.ResetColor();
				}

				Thread.Sleep(100);
				snake.Move();

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.PressKey(key.Key);
				}
			}

			user.Score = score;
			_userService.SaveScore();

			//ConsoleKeyInfo key = Console.ReadKey();
			//Console.WriteLine(key.Key);

		}
	}
}
